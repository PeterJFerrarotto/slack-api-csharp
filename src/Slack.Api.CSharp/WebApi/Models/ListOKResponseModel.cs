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
    /// api.permissions.scopes.list success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response api.permissions.scopes.list method
    /// </remarks>
    public partial class ListOKResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the ListOKResponseModel class.
        /// </summary>
        public ListOKResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListOKResponseModel class.
        /// </summary>
        public ListOKResponseModel(ListOKResponseScopes scopes)
        {
            Scopes = scopes;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for ListOKResponseModel class.
        /// </summary>
        static ListOKResponseModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "scopes")]
        public ListOKResponseScopes Scopes { get; set; }

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
            if (Scopes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Scopes");
            }
        }
    }
}
