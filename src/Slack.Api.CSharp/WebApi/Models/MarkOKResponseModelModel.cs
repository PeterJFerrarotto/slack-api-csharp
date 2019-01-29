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
    /// im.mark success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response im.mark method
    /// </remarks>
    public partial class MarkOKResponseModelModel
    {
        /// <summary>
        /// Initializes a new instance of the MarkOKResponseModelModel class.
        /// </summary>
        public MarkOKResponseModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for MarkOKResponseModelModel class.
        /// </summary>
        static MarkOKResponseModelModel()
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
