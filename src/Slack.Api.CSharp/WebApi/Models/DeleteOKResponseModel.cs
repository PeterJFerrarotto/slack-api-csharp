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
    /// files.comments.delete schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response files.comments.delete method
    /// </remarks>
    public partial class DeleteOKResponseModel
    {
        /// <summary>
        /// Initializes a new instance of the DeleteOKResponseModel class.
        /// </summary>
        public DeleteOKResponseModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Static constructor for DeleteOKResponseModel class.
        /// </summary>
        static DeleteOKResponseModel()
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
