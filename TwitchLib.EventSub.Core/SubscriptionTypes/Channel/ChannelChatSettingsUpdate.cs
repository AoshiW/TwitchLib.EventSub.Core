namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

/// <summary>
/// Channel Chat Settings Update subscription type model
/// <para>Description:</para>
/// <para>A notification for when a broadcaster’s chat settings are updated.</para>
/// </summary>
public sealed class ChannelChatSettingsUpdate
{
    /// <summary>
    /// The ID of the broadcaster specified in the request.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the broadcaster specified in the request.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The user name of the broadcaster specified in the request.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// A Boolean value that determines whether chat messages must contain only emotes.
    /// True if only messages that are 100% emotes are allowed; otherwise false.
    /// </summary>
    public bool EmoteMode { get; set; }
    /// <summary>
    /// A Boolean value that determines whether the broadcaster restricts the chat room to followers only, based on how long they’ve followed.
    /// True if the broadcaster restricts the chat room to followers only; otherwise false.
    /// See <see cref="FollowerModeDurationMinutes" /> for how long the followers must have followed the broadcaster to participate in the chat room.
    /// </summary>
    public bool FollowerMode { get; set; }
    /// <summary>
    ///	The length of time, in minutes, that the followers must have followed the broadcaster to participate in the chat room. See <see cref="FollowerMode"/>.
    /// Null if <see cref="FollowerMode"/> is false.
    /// </summary>
    public int? FollowerModeDurationMinutes { get; set; }
    /// <summary>
    /// A Boolean value that determines whether the broadcaster limits how often users in the chat room are allowed to send messages.
    /// Is true, if the broadcaster applies a delay; otherwise, false.
    /// See <see cref="SlowModeWaitTimeSeconds"/> for the delay.
    /// </summary>
    public bool SlowMode { get; set; }
    /// <summary>
    /// The amount of time, in seconds, that users need to wait between sending messages. See slow_mode.
    /// Null if <see cref="SlowMode"/> is false.
    /// </summary>
    public int? SlowModeWaitTimeSeconds { get; set; }
    /// <summary>
    /// Boolean value that determines whether only users that subscribe to the broadcaster’s channel can talk in the chat room.
    /// True if the broadcaster restricts the chat room to subscribers only; otherwise false.
    /// </summary>
    public bool SubscriberMode { get; set; }
    /// <summary>
    /// A Boolean value that determines whether the broadcaster requires users to post only unique messages in the chat room.
    /// True if the broadcaster requires unique messages only; otherwise false.
    /// </summary>
    public bool UniqueChatMode { get; set; }
}
