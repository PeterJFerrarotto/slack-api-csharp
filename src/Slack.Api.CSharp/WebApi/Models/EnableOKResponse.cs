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
    /// Default success template
    /// </summary>
    /// <remarks>
    /// Verbose schema not yet ready for this method.
    /// </remarks>
    public partial class EnableOKResponse
    {
        /// <summary>
        /// Initializes a new instance of the EnableOKResponse class.
        /// </summary>
        public EnableOKResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for EnableOKResponse class.
        /// </summary>
        static EnableOKResponse()
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
