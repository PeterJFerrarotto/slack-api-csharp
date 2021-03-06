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
    /// team.profile.get success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from team.profile.get method
    /// </remarks>
    public partial class GetOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the GetOKResponse class.
        /// </summary>
        public GetOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the GetOKResponse class.
        /// </summary>
        public GetOKResponse(GetOKResponseProfile profile)
        {
            Profile = profile;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for GetOKResponse class.
        /// </summary>
        static GetOKResponse()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public GetOKResponseProfile Profile { get; set; }

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
            if (Profile == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Profile");
            }
            if (Profile != null)
            {
                Profile.Validate();
            }
        }
    }
}
