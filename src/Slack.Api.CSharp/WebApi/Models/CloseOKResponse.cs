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
    /// conversations.close success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response conversations.close method
    /// </remarks>
    public partial class CloseOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the CloseOKResponse class.
        /// </summary>
        public CloseOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CloseOKResponse class.
        /// </summary>
        public CloseOKResponse(bool? alreadyClosed = default(bool?), bool? noOp = default(bool?))
        {
            AlreadyClosed = alreadyClosed;
            NoOp = noOp;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for CloseOKResponse class.
        /// </summary>
        static CloseOKResponse()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "already_closed")]
        public bool? AlreadyClosed { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "no_op")]
        public bool? NoOp { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ok")]
        public static bool Ok { get; private set; }

    }
}
