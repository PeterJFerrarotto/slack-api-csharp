// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// conversations.leave success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from conversations.leave method
    /// </remarks>
    public partial class LeaveOKResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the LeaveOKResponseModel class.
        /// </summary>
        public LeaveOKResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LeaveOKResponseModel class.
        /// </summary>
        public LeaveOKResponseModel(bool? notInChannel = default(bool?))
        {
            NotInChannel = notInChannel;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for LeaveOKResponseModel class.
        /// </summary>
        static LeaveOKResponseModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "not_in_channel")]
        public bool? NotInChannel { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ok")]
        public static bool Ok { get; private set; }

    }
}
