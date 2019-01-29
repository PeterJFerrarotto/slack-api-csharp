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
    /// users.info success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from users.info method
    /// </remarks>
    public partial class InfoOKResponseModelModelModelModelModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InfoOKResponseModelModelModelModelModelModelModel class.
        /// </summary>
        public InfoOKResponseModelModelModelModelModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InfoOKResponseModelModelModelModelModelModelModel class.
        /// </summary>
        public InfoOKResponseModelModelModelModelModelModelModel(ObjsUser user)
        {
            User = user;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for
        /// InfoOKResponseModelModelModelModelModelModelModel class.
        /// </summary>
        static InfoOKResponseModelModelModelModelModelModelModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public ObjsUser User { get; set; }

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
            if (User == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "User");
            }
            if (User != null)
            {
                User.Validate();
            }
        }
    }
}
