// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// conversations.unarchive error schema
    /// </summary>
    /// <remarks>
    /// Schema for error response from conversations.unarchive method
    /// </remarks>
    public partial class UnarchiveErrorModel1
    {
        /// <summary>
        /// Initializes a new instance of the UnarchiveErrorModel1 class.
        /// </summary>
        public UnarchiveErrorModel1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UnarchiveErrorModel1 class.
        /// </summary>
        /// <param name="error">Possible values include:
        /// 'method_not_supported_for_channel_type', 'missing_scope',
        /// 'channel_not_found', 'not_archived', 'not_authed', 'invalid_auth',
        /// 'account_inactive', 'user_is_bot', 'user_is_restricted',
        /// 'user_is_ultra_restricted', 'invalid_arg_name',
        /// 'invalid_array_arg', 'invalid_charset', 'invalid_form_data',
        /// 'invalid_post_type', 'missing_post_type', 'invalid_json',
        /// 'json_not_object', 'request_timeout', 'upgrade_required',
        /// 'team_added_to_org', 'missing_charset',
        /// 'superfluous_charset'</param>
        public UnarchiveErrorModel1(string error, string needed = default(string), string provided = default(string))
        {
            Error = error;
            Needed = needed;
            Provided = provided;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for UnarchiveErrorModel1 class.
        /// </summary>
        static UnarchiveErrorModel1()
        {
            Ok = false;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include:
        /// 'method_not_supported_for_channel_type', 'missing_scope',
        /// 'channel_not_found', 'not_archived', 'not_authed', 'invalid_auth',
        /// 'account_inactive', 'user_is_bot', 'user_is_restricted',
        /// 'user_is_ultra_restricted', 'invalid_arg_name',
        /// 'invalid_array_arg', 'invalid_charset', 'invalid_form_data',
        /// 'invalid_post_type', 'missing_post_type', 'invalid_json',
        /// 'json_not_object', 'request_timeout', 'upgrade_required',
        /// 'team_added_to_org', 'missing_charset', 'superfluous_charset'
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "needed")]
        public string Needed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provided")]
        public string Provided { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ok")]
        public static bool Ok { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Error == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Error");
            }
        }
    }
}
