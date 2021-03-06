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
    /// conversations.setTopic success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from conversations.setTopic method
    /// </remarks>
    public partial class SetTopicOKResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the SetTopicOKResponseModel class.
        /// </summary>
        public SetTopicOKResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SetTopicOKResponseModel class.
        /// </summary>
        public SetTopicOKResponseModel(object channel)
        {
            Channel = channel;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for SetTopicOKResponseModel class.
        /// </summary>
        static SetTopicOKResponseModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "channel")]
        public object Channel { get; set; }

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
            if (Channel == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Channel");
            }
        }
    }
}
