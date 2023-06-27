#pragma warning disable 108 // new keyword hiding
#pragma warning disable 114 // new keyword hiding
namespace Windows.Media.Playback
{
	#if false || false || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
	[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
	#endif
	public  partial class MediaPlaybackItem : global::Windows.Media.Playback.IMediaPlaybackSource
	{
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Playback.MediaPlaybackAudioTrackList AudioTracks
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlaybackAudioTrackList MediaPlaybackItem.AudioTracks is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaPlaybackAudioTrackList%20MediaPlaybackItem.AudioTracks");
			}
		}
		#endif
<<<<<<< HEAD
		#if false || false || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
=======
		#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__NETSTD_REFERENCE__")]
>>>>>>> 8bc4223730 (chore: changes from rebase)
		public  global::Windows.Media.Core.MediaSource Source
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaSource MediaPlaybackItem.Source is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaSource%20MediaPlaybackItem.Source");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Playback.MediaPlaybackTimedMetadataTrackList TimedMetadataTracks
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlaybackTimedMetadataTrackList MediaPlaybackItem.TimedMetadataTracks is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaPlaybackTimedMetadataTrackList%20MediaPlaybackItem.TimedMetadataTracks");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Playback.MediaPlaybackVideoTrackList VideoTracks
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaPlaybackVideoTrackList MediaPlaybackItem.VideoTracks is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaPlaybackVideoTrackList%20MediaPlaybackItem.VideoTracks");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool CanSkip
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlaybackItem.CanSkip is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20MediaPlaybackItem.CanSkip");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "bool MediaPlaybackItem.CanSkip");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Playback.MediaBreakSchedule BreakSchedule
		{
			get
			{
				throw new global::System.NotImplementedException("The member MediaBreakSchedule MediaPlaybackItem.BreakSchedule is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaBreakSchedule%20MediaPlaybackItem.BreakSchedule");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan? DurationLimit
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan? MediaPlaybackItem.DurationLimit is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%3F%20MediaPlaybackItem.DurationLimit");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::System.TimeSpan StartTime
		{
			get
			{
				throw new global::System.NotImplementedException("The member TimeSpan MediaPlaybackItem.StartTime is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=TimeSpan%20MediaPlaybackItem.StartTime");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  bool IsDisabledInPlaybackList
		{
			get
			{
				throw new global::System.NotImplementedException("The member bool MediaPlaybackItem.IsDisabledInPlaybackList is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=bool%20MediaPlaybackItem.IsDisabledInPlaybackList");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "bool MediaPlaybackItem.IsDisabledInPlaybackList");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  global::Windows.Media.Playback.AutoLoadedDisplayPropertyKind AutoLoadedDisplayProperties
		{
			get
			{
				throw new global::System.NotImplementedException("The member AutoLoadedDisplayPropertyKind MediaPlaybackItem.AutoLoadedDisplayProperties is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=AutoLoadedDisplayPropertyKind%20MediaPlaybackItem.AutoLoadedDisplayProperties");
			}
			set
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "AutoLoadedDisplayPropertyKind MediaPlaybackItem.AutoLoadedDisplayProperties");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  double TotalDownloadProgress
		{
			get
			{
				throw new global::System.NotImplementedException("The member double MediaPlaybackItem.TotalDownloadProgress is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=double%20MediaPlaybackItem.TotalDownloadProgress");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MediaPlaybackItem( global::Windows.Media.Core.MediaSource source,  global::System.TimeSpan startTime) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "MediaPlaybackItem.MediaPlaybackItem(MediaSource source, TimeSpan startTime)");
		}
		#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.MediaPlaybackItem(Windows.Media.Core.MediaSource, System.TimeSpan)
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public MediaPlaybackItem( global::Windows.Media.Core.MediaSource source,  global::System.TimeSpan startTime,  global::System.TimeSpan durationLimit) 
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "MediaPlaybackItem.MediaPlaybackItem(MediaSource source, TimeSpan startTime, TimeSpan durationLimit)");
		}
		#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.MediaPlaybackItem(Windows.Media.Core.MediaSource, System.TimeSpan, System.TimeSpan)
<<<<<<< HEAD
		#if false || false || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public MediaPlaybackItem( global::Windows.Media.Core.MediaSource source) 
=======
#if false || false || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || false
		[global::Uno.NotImplemented("IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__")]
		public MediaPlaybackItem(global::Windows.Media.Core.MediaSource source) 
>>>>>>> 8bc4223730 (chore: changes from rebase)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "MediaPlaybackItem.MediaPlaybackItem(MediaSource source)");
		}
		#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.MediaPlaybackItem(Windows.Media.Core.MediaSource)
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.AudioTracksChanged.add
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.AudioTracksChanged.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.VideoTracksChanged.add
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.VideoTracksChanged.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.TimedMetadataTracksChanged.add
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.TimedMetadataTracksChanged.remove
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.Source.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.AudioTracks.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.VideoTracks.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.TimedMetadataTracks.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.BreakSchedule.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.StartTime.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.DurationLimit.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.CanSkip.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.CanSkip.set
<<<<<<< HEAD
<<<<<<< HEAD
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
=======
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || false || false || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__NETSTD_REFERENCE__", "__MACOS__")]
>>>>>>> 8bc4223730 (chore: changes from rebase)
=======
#if __ANDROID__ || __IOS__ || IS_UNIT_TESTS || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "IS_UNIT_TESTS", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
>>>>>>> 036277cf1f (chore: fix for skia)
		public  global::Windows.Media.Playback.MediaItemDisplayProperties GetDisplayProperties()
		{
			throw new global::System.NotImplementedException("The member MediaItemDisplayProperties MediaPlaybackItem.GetDisplayProperties() is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaItemDisplayProperties%20MediaPlaybackItem.GetDisplayProperties%28%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  void ApplyDisplayProperties( global::Windows.Media.Playback.MediaItemDisplayProperties value)
		{
			global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "void MediaPlaybackItem.ApplyDisplayProperties(MediaItemDisplayProperties value)");
		}
		#endif
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.IsDisabledInPlaybackList.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.IsDisabledInPlaybackList.set
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.TotalDownloadProgress.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.AutoLoadedDisplayProperties.get
		// Forced skipping of method Windows.Media.Playback.MediaPlaybackItem.AutoLoadedDisplayProperties.set
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public static global::Windows.Media.Playback.MediaPlaybackItem FindFromMediaSource( global::Windows.Media.Core.MediaSource source)
		{
			throw new global::System.NotImplementedException("The member MediaPlaybackItem MediaPlaybackItem.FindFromMediaSource(MediaSource source) is not implemented. For more information, visit https://aka.platform.uno/notimplemented?m=MediaPlaybackItem%20MediaPlaybackItem.FindFromMediaSource%28MediaSource%20source%29");
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlaybackItem, global::Windows.Foundation.Collections.IVectorChangedEventArgs> AudioTracksChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> MediaPlaybackItem.AudioTracksChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> MediaPlaybackItem.AudioTracksChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlaybackItem, global::Windows.Foundation.Collections.IVectorChangedEventArgs> TimedMetadataTracksChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> MediaPlaybackItem.TimedMetadataTracksChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> MediaPlaybackItem.TimedMetadataTracksChanged");
			}
		}
		#endif
		#if __ANDROID__ || __IOS__ || NET461 || __WASM__ || __SKIA__ || __NETSTD_REFERENCE__ || __MACOS__
		[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
		public  event global::Windows.Foundation.TypedEventHandler<global::Windows.Media.Playback.MediaPlaybackItem, global::Windows.Foundation.Collections.IVectorChangedEventArgs> VideoTracksChanged
		{
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			add
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> MediaPlaybackItem.VideoTracksChanged");
			}
			[global::Uno.NotImplemented("__ANDROID__", "__IOS__", "NET461", "__WASM__", "__SKIA__", "__NETSTD_REFERENCE__", "__MACOS__")]
			remove
			{
				global::Windows.Foundation.Metadata.ApiInformation.TryRaiseNotImplemented("Windows.Media.Playback.MediaPlaybackItem", "event TypedEventHandler<MediaPlaybackItem, IVectorChangedEventArgs> MediaPlaybackItem.VideoTracksChanged");
			}
		}
		#endif
		// Processing: Windows.Media.Playback.IMediaPlaybackSource
	}
}
