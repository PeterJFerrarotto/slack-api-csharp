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
    /// channels.invite error schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response channels.invite method
    /// </remarks>
    public partial class InviteOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the InviteOKResponse class.
        /// </summary>
        public InviteOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the InviteOKResponse class.
        /// </summary>
        public InviteOKResponse(ObjsChannel channel)
        {
            Channel = channel;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for InviteOKResponse class.
        /// </summary>
        static InviteOKResponse()
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
        public ObjsChannel Channel { get; set; }

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
            if (Channel != null)
            {
                Channel.Validate();
            }
        }
    }
}
