﻿#nullable enable

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Uno.UI.RemoteControl.Messaging.IdeChannel;

internal interface IIdeChannelServer
{
	Task SendToDevServerAsync(IdeMessageEnvelope message);

	event EventHandler<IdeMessageEnvelope>? MessageFromDevServer;

	event EventHandler<IdeMessage>? MessageFromIde;
}
