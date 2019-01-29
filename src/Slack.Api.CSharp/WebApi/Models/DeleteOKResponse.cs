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
    /// chat.delete success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response of chat.delete method
    /// </remarks>
    public partial class DeleteOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the DeleteOKResponse class.
        /// </summary>
        public DeleteOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DeleteOKResponse class.
        /// </summary>
        public DeleteOKResponse(string channel, string ts)
        {
            Channel = channel;
            Ts = ts;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for DeleteOKResponse class.
        /// </summary>
        static DeleteOKResponse()
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
        public string Channel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ts")]
        public string Ts { get; set; }

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
            if (Ts == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Ts");
            }
        }
    }
}
