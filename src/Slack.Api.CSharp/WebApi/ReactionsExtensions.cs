// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Reactions.
    /// </summary>
    public static partial class ReactionsExtensions
    {
            /// <summary>
            /// Adds a reaction to an item.
            /// <see href="https://api.slack.com/methods/reactions.add" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `reactions:write`
            /// </param>
            /// <param name='name'>
            /// Reaction (emoji) name.
            /// </param>
            /// <param name='fileComment'>
            /// File comment to add reaction to.
            /// </param>
            /// <param name='timestamp'>
            /// Timestamp of the message to add reaction to.
            /// </param>
            /// <param name='file'>
            /// File to add reaction to.
            /// </param>
            /// <param name='channel'>
            /// Channel where the message to add reaction to was posted.
            /// </param>
            public static AddOKResponseModelModel Add(this IReactions operations, string token = default(string), string name = default(string), string fileComment = default(string), double? timestamp = default(double?), string file = default(string), string channel = default(string))
            {
                return operations.AddAsync(token, name, fileComment, timestamp, file, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a reaction to an item.
            /// <see href="https://api.slack.com/methods/reactions.add" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `reactions:write`
            /// </param>
            /// <param name='name'>
            /// Reaction (emoji) name.
            /// </param>
            /// <param name='fileComment'>
            /// File comment to add reaction to.
            /// </param>
            /// <param name='timestamp'>
            /// Timestamp of the message to add reaction to.
            /// </param>
            /// <param name='file'>
            /// File to add reaction to.
            /// </param>
            /// <param name='channel'>
            /// Channel where the message to add reaction to was posted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AddOKResponseModelModel> AddAsync(this IReactions operations, string token = default(string), string name = default(string), string fileComment = default(string), double? timestamp = default(double?), string file = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.AddWithHttpMessagesAsync(token, name, fileComment, timestamp, file, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets reactions for an item.
            /// <see href="https://api.slack.com/methods/reactions.get" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='full'>
            /// If true always return the complete reaction list.
            /// </param>
            /// <param name='fileComment'>
            /// File comment to get reactions for.
            /// </param>
            /// <param name='timestamp'>
            /// Timestamp of the message to get reactions for.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `reactions:read`
            /// </param>
            /// <param name='file'>
            /// File to get reactions for.
            /// </param>
            /// <param name='channel'>
            /// Channel where the message to get reactions for was posted.
            /// </param>
            public static object Get(this IReactions operations, bool? full = default(bool?), string fileComment = default(string), double? timestamp = default(double?), string token = default(string), string file = default(string), string channel = default(string))
            {
                return operations.GetAsync(full, fileComment, timestamp, token, file, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets reactions for an item.
            /// <see href="https://api.slack.com/methods/reactions.get" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='full'>
            /// If true always return the complete reaction list.
            /// </param>
            /// <param name='fileComment'>
            /// File comment to get reactions for.
            /// </param>
            /// <param name='timestamp'>
            /// Timestamp of the message to get reactions for.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `reactions:read`
            /// </param>
            /// <param name='file'>
            /// File to get reactions for.
            /// </param>
            /// <param name='channel'>
            /// Channel where the message to get reactions for was posted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<object> GetAsync(this IReactions operations, bool? full = default(bool?), string fileComment = default(string), double? timestamp = default(double?), string token = default(string), string file = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(full, fileComment, timestamp, token, file, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists reactions made by a user.
            /// <see href="https://api.slack.com/methods/reactions.list" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `reactions:read`
            /// </param>
            /// <param name='full'>
            /// If true always return the complete reaction list.
            /// </param>
            /// <param name='user'>
            /// Show reactions made by this user. Defaults to the authed user.
            /// </param>
            /// <param name='page'>
            /// </param>
            public static ListOKResponseModelModelModelModelModelModelModelModel List(this IReactions operations, string count = default(string), string token = default(string), bool? full = default(bool?), string user = default(string), string page = default(string))
            {
                return operations.ListAsync(count, token, full, user, page).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists reactions made by a user.
            /// <see href="https://api.slack.com/methods/reactions.list" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='count'>
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `reactions:read`
            /// </param>
            /// <param name='full'>
            /// If true always return the complete reaction list.
            /// </param>
            /// <param name='user'>
            /// Show reactions made by this user. Defaults to the authed user.
            /// </param>
            /// <param name='page'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ListOKResponseModelModelModelModelModelModelModelModel> ListAsync(this IReactions operations, string count = default(string), string token = default(string), bool? full = default(bool?), string user = default(string), string page = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(count, token, full, user, page, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Removes a reaction from an item.
            /// <see href="https://api.slack.com/methods/reactions.remove" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `reactions:write`
            /// </param>
            /// <param name='name'>
            /// Reaction (emoji) name.
            /// </param>
            /// <param name='fileComment'>
            /// File comment to remove reaction from.
            /// </param>
            /// <param name='timestamp'>
            /// Timestamp of the message to remove reaction from.
            /// </param>
            /// <param name='file'>
            /// File to remove reaction from.
            /// </param>
            /// <param name='channel'>
            /// Channel where the message to remove reaction from was posted.
            /// </param>
            public static RemoveOKResponseModel Remove(this IReactions operations, string token = default(string), string name = default(string), string fileComment = default(string), double? timestamp = default(double?), string file = default(string), string channel = default(string))
            {
                return operations.RemoveAsync(token, name, fileComment, timestamp, file, channel).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Removes a reaction from an item.
            /// <see href="https://api.slack.com/methods/reactions.remove" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='token'>
            /// Authentication token. Requires scope: `reactions:write`
            /// </param>
            /// <param name='name'>
            /// Reaction (emoji) name.
            /// </param>
            /// <param name='fileComment'>
            /// File comment to remove reaction from.
            /// </param>
            /// <param name='timestamp'>
            /// Timestamp of the message to remove reaction from.
            /// </param>
            /// <param name='file'>
            /// File to remove reaction from.
            /// </param>
            /// <param name='channel'>
            /// Channel where the message to remove reaction from was posted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<RemoveOKResponseModel> RemoveAsync(this IReactions operations, string token = default(string), string name = default(string), string fileComment = default(string), double? timestamp = default(double?), string file = default(string), string channel = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RemoveWithHttpMessagesAsync(token, name, fileComment, timestamp, file, channel, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
