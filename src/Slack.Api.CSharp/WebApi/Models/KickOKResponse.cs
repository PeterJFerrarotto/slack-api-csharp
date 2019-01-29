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
    /// channels.kick schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from channels.kick method
    /// </remarks>
    public partial class KickOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the KickOKResponse class.
        /// </summary>
        public KickOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for KickOKResponse class.
        /// </summary>
        static KickOKResponse()
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