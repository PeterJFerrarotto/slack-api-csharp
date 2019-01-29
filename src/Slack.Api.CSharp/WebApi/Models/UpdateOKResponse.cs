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
    /// chat.update success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response of chat.update method
    /// </remarks>
    public partial class UpdateOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the UpdateOKResponse class.
        /// </summary>
        public UpdateOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UpdateOKResponse class.
        /// </summary>
        /// <param name="text">Updated message text</param>
        public UpdateOKResponse(string channel, string text, string ts)
        {
            Channel = channel;
            Text = text;
            Ts = ts;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for UpdateOKResponse class.
        /// </summary>
        static UpdateOKResponse()
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
        /// Gets or sets updated message text
        /// </summary>
        [JsonProperty(PropertyName = "text")]
        public string Text { get; set; }

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
            if (Text == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Text");
            }
            if (Ts == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Ts");
            }
        }
    }
}