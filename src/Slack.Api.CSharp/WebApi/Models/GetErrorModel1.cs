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
    /// team.profile.get error schema
    /// </summary>
    /// <remarks>
    /// Schema for error response from team.profile.get method
    /// </remarks>
    public partial class GetErrorModel1
    {
        /// <summary>
        /// Initializes a new instance of the GetErrorModel1 class.
        /// </summary>
        public GetErrorModel1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetErrorModel1 class.
        /// </summary>
        /// <param name="error">Possible values include: 'not_authed',
        /// 'invalid_auth', 'account_inactive', 'no_permission', 'user_is_bot',
        /// 'invalid_arg_name', 'invalid_array_arg', 'invalid_charset',
        /// 'invalid_form_data', 'invalid_post_typ', 'missing_post_type',
        /// 'team_added_to_org', 'invalid_json', 'json_not_object',
        /// 'request_timeou', 'upgrade_required'</param>
        public GetErrorModel1(string error)
        {
            Error = error;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for GetErrorModel1 class.
        /// </summary>
        static GetErrorModel1()
        {
            Ok = false;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'not_authed', 'invalid_auth',
        /// 'account_inactive', 'no_permission', 'user_is_bot',
        /// 'invalid_arg_name', 'invalid_array_arg', 'invalid_charset',
        /// 'invalid_form_data', 'invalid_post_typ', 'missing_post_type',
        /// 'team_added_to_org', 'invalid_json', 'json_not_object',
        /// 'request_timeou', 'upgrade_required'
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

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
