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
    /// files.delete schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response files.delete method
    /// </remarks>
    public partial class DeleteOKResponseModelModel
    {
        /// <summary>
        /// Initializes a new instance of the DeleteOKResponseModelModel class.
        /// </summary>
        public DeleteOKResponseModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for DeleteOKResponseModelModel class.
        /// </summary>
        static DeleteOKResponseModelModel()
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