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
    /// dnd.teamInfo error schema
    /// </summary>
    /// <remarks>
    /// Schema for error response from dnd.teamInfo method
    /// </remarks>
    public partial class TeamInfoErrorModel
    {
        /// <summary>
        /// Initializes a new instance of the TeamInfoErrorModel class.
        /// </summary>
        public TeamInfoErrorModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TeamInfoErrorModel class.
        /// </summary>
        /// <param name="error">Possible values include: 'not_authed',
        /// 'invalid_auth', 'account_inactive', 'invalid_arg_name',
        /// 'invalid_array_arg', 'invalid_charset', 'invalid_form_data',
        /// 'invalid_post_type', 'missing_post_type', 'team_added_to_org',
        /// 'request_timeout', 'upgrade_required'</param>
        public TeamInfoErrorModel(string error, string needed = default(string), string provided = default(string))
        {
            Error = error;
            Needed = needed;
            Provided = provided;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for TeamInfoErrorModel class.
        /// </summary>
        static TeamInfoErrorModel()
        {
            Ok = false;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'not_authed', 'invalid_auth',
        /// 'account_inactive', 'invalid_arg_name', 'invalid_array_arg',
        /// 'invalid_charset', 'invalid_form_data', 'invalid_post_type',
        /// 'missing_post_type', 'team_added_to_org', 'request_timeout',
        /// 'upgrade_required'
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
