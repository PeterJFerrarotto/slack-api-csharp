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

    public partial class ObjsChannelPurpose
    {
        /// <summary>
        /// Initializes a new instance of the ObjsChannelPurpose class.
        /// </summary>
        public ObjsChannelPurpose()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ObjsChannelPurpose class.
        /// </summary>
        public ObjsChannelPurpose(string creator, int lastSet, string value)
        {
            Creator = creator;
            LastSet = lastSet;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "creator")]
        public string Creator { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "last_set")]
        public int LastSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public string Value { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Creator == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Creator");
            }
            if (Value == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Value");
            }
        }
    }
}
