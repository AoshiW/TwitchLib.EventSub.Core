using System;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Conduit;

// todo

/// <summary>
/// Conduit Shard Disabled subscription type model
/// <para>Description:</para>
/// <para>Sends a notification when EventSub disables a shard due to the status of the underlying transport changing.</para>
/// </summary>
public sealed class ConduitShardDisabled
{
    /// <summary>
    /// The ID of the conduit.
    /// </summary>
    public string ConduitId { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the disabled shard.
    /// </summary>
    public string ShardId { get; set; } = string.Empty;
    /// <summary>
    /// The new status of the transport.
    /// </summary>
    public string Status { get; set; } = string.Empty;
    public Transport Transport { get; set; } = new();
}
public sealed class Transport
{
    /// <summary>
    /// websocket or webhook
    /// </summary>
    public string Method { get; set; } = string.Empty;
    /// <summary>
    /// Optional. Webhook callback URL.
    /// Null if method is set to websocket.
    /// </summary>
    public string? Callback { get; set; }
    /// <summary>
    /// Optional. WebSocket session ID.
    /// Null if  method is set to webhook.
    /// </summary>
    public string? SessionId { get; set; }
    /// <summary>
    /// Optional. Time that the WebSocket session connected.
    /// Null if method is set to webhook.
    /// </summary>
    public DateTimeOffset? ConnectedAt { get; set; }
    /// <summary>
    /// Optional. Time that the WebSocket session disconnected.
    /// Null if method is set to webhook.
    /// </summary>
    public DateTimeOffset? DisconnectedAt { get; set; }
}
