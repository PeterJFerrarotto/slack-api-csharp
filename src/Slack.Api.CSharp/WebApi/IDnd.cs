// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Dnd operations.
    /// </summary>
    public partial interface IDnd
    {
        /// <summary>
        /// Ends the current user's Do Not Disturb session immediately.
        /// <see href="https://api.slack.com/methods/dnd.endDnd" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `dnd:write`
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="EndDndErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<EndDndOKResponse>> EndDndWithHttpMessagesAsync(string token = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Ends the current user's snooze mode immediately.
        /// <see href="https://api.slack.com/methods/dnd.endSnooze" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `dnd:write`
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="EndSnoozeErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<EndSnoozeOKResponse>> EndSnoozeWithHttpMessagesAsync(string token = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves a user's current Do Not Disturb status.
        /// <see href="https://api.slack.com/methods/dnd.info" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `dnd:read`
        /// </param>
        /// <param name='user'>
        /// User to fetch status for (defaults to current user)
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="InfoErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<InfoOKResponse>> InfoWithHttpMessagesAsync(string token = default(string), string user = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Turns on Do Not Disturb mode for the current user, or changes its
        /// duration.
        /// <see href="https://api.slack.com/methods/dnd.setSnooze" />
        /// </summary>
        /// <param name='numMinutes'>
        /// Number of minutes, from now, to snooze until.
        /// </param>
        /// <param name='token'>
        /// Authentication token. Requires scope: `dnd:write`
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="SetSnoozeErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<SetSnoozeOKResponse>> SetSnoozeWithHttpMessagesAsync(int? numMinutes = default(int?), string token = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves the Do Not Disturb status for users on a team.
        /// <see href="https://api.slack.com/methods/dnd.teamInfo" />
        /// </summary>
        /// <param name='token'>
        /// Authentication token. Requires scope: `dnd:read`
        /// </param>
        /// <param name='users'>
        /// Comma-separated list of users to fetch Do Not Disturb status for
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="TeamInfoErrorModelException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        Task<HttpOperationResponse<TeamInfoOKResponse>> TeamInfoWithHttpMessagesAsync(string token = default(string), string users = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
