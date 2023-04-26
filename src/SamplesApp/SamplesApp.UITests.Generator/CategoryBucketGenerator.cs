﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Microsoft.CodeAnalysis;
using Uno.Extensions;

namespace Uno.Samples.UITest.Generator
{
	[Generator]
	public class CategoryBucketGenerator : ISourceGenerator
	{
		public void Initialize(GeneratorInitializationContext context)
		{
		}

		public void Execute(GeneratorExecutionContext context)
		{
#if DEBUG
			// Debugger.Launch();
#endif

			GenerateTests(context);
		}

		private static void GenerateTests(GeneratorExecutionContext context)
		{
			if (context.Compilation.Assembly.Name == "SamplesApp.UITests")
			{
				var testAttribute = context.Compilation.GetTypeByMetadataName("NUnit.Framework.TestAttribute");

				var query = from typeSymbol in context.Compilation.SourceModule.GlobalNamespace.GetNamespaceTypes()
							where typeSymbol.DeclaredAccessibility == Accessibility.Public
							where typeSymbol.GetMembers().OfType<IMethodSymbol>().Any(m => m.FindAttributeFlattened(testAttribute) != null)
							select typeSymbol;

				GenerateCategories(context, query);
			}
		}

		private static void GenerateCategories(
			GeneratorExecutionContext context,
			IEnumerable<INamedTypeSymbol> symbols)
		{
			using var sha1 = SHA1.Create();

			int.TryParse(Environment.GetEnvironmentVariable("UNO_UITEST_BUCKET_COUNT"), out var bucketCount);

			foreach (var type in symbols)
			{
				var fullMetadataName = type.GetFullMetadataName();
				var builder = new IndentedStringBuilder();
				using (builder.BlockInvariant($"namespace {type.ContainingNamespace}"))
				{
					if(bucketCount != 0)
					{
						// Compute a stable hash of the full metadata name
						var buffer = Encoding.UTF8.GetBytes(fullMetadataName);
						var hash = sha1.ComputeHash(buffer);
						var hashPart64 = BitConverter.ToUInt64(hash, 0);

						var testCategoryBucket = (hashPart64 % (uint)bucketCount) + 1;

						builder.AppendLineIndented($"[global::NUnit.Framework.Category(\"testBucket:{testCategoryBucket}\")]");
					}

					// Always generate the namespace property, so we can 
					builder.AppendLineIndented($"[global::NUnit.Framework.Property(\"Namespace\", \"{type.ContainingNamespace}\")]");
					using (builder.BlockInvariant($"partial class {type.Name}"))
					{

					}
				}

				context.AddSource(Sanitize(fullMetadataName), builder.ToString());
			}
		}

		private static string Sanitize(string category)
			=> category
				.Replace(' ', '_')
				.Replace('-', '_')
				.Replace('.', '_');
	}
}
