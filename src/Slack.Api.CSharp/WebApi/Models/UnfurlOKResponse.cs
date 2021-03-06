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
    /// chat.unfurl success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from chat.unfurl method
    /// </remarks>
    public partial class UnfurlOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the UnfurlOKResponse class.
        /// </summary>
        public UnfurlOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for UnfurlOKResponse class.
        /// </summary>
        static UnfurlOKResponse()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ok")]
        public static bool Ok { get; private set; }

    }
}
