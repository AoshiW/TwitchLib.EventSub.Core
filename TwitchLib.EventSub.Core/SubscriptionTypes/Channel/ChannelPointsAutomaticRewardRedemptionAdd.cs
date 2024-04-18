using System;

namespace TwitchLib.EventSub.Core.SubscriptionTypes.Channel;

// todo

/// <summary>
/// Channel Points Automatic Reward Redemption subscription type model
/// <para>Description:</para>
/// <para>A viewer has redeemed an automatic channel points reward on the specified channel.</para>
/// </summary>
public sealed class ChannelPointsAutomaticRewardRedemptionAdd
{
    /// <summary>
    /// The ID of the channel where the reward was redeemed.
    /// </summary>
    public string BroadcasterUserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the channel where the reward was redeemed.
    /// </summary>
    public string BroadcasterUserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the channel where the reward was redeemed.
    /// </summary>
    public string BroadcasterUserName { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the redeeming user.
    /// </summary>
    public string UserId { get; set; } = string.Empty;
    /// <summary>
    /// The login of the redeeming user.
    /// </summary>
    public string UserLogin { get; set; } = string.Empty;
    /// <summary>
    /// The display name of the redeeming user.
    /// </summary>
    public string UserName { get; set; } = string.Empty;
    /// <summary>
    /// The ID of the Redemption
    /// </summary>
    public string Id { get; set; } = string.Empty;
    public Reward Reward { get; set; } = new();
    public Message Message { get; set; } = new();
    /// <summary>
    /// Optional. A string that the user entered if the reward requires input.
    /// </summary>
    public string? UserInput { get; set; }
    /// <summary>
    /// The UTC date and time of when the reward was redeemed.
    /// </summary>
    public DateTimeOffset RedeemedAt { get; set; }
}
public sealed class Message
{
    /// <summary>
    /// The text of the chat message.
    /// </summary>
    public string Text { get; set; } = string.Empty;
    public Emote[] Emotes { get; set; } = [];
}
public sealed class Reward
{
    /// <summary>
    /// The type of reward. 
    /// One of: ssingle_message_bypass_sub_mode, send_highlighted_message, random_sub_emote_unlock, chosen_sub_emote_unlock, chosen_modified_sub_emote_unlock
    /// </summary>
    public string Type { get; set; } = string.Empty;
    /// <summary>
    /// The reward cost.
    /// </summary>
    public int Cost { get; set; }
    public UnlockedEmote? UnlockedEmote { get; set; }
}
public sealed class Emote
{
    /// <summary>
    /// The emote ID.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// The index of where the Emote starts in the text.
    /// </summary>
    public int Begin { get; set; }
    /// <summary>
    /// The index of where the Emote ends in the text.
    /// </summary>
    public int End { get; set; }
}
public sealed class UnlockedEmote
{
    /// <summary>
    /// The emote ID.
    /// </summary>
    public string Id { get; set; } = string.Empty;
    /// <summary>
    /// The human readable emote token.
    /// </summary>
    public string Name { get; set; } = string.Empty;
}
