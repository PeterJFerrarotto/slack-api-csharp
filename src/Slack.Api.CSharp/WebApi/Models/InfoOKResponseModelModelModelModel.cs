// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// files.info schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from files.info method
    /// </remarks>
    public partial class InfoOKResponseModelModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// InfoOKResponseModelModelModelModel class.
        /// </summary>
        public InfoOKResponseModelModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// InfoOKResponseModelModelModelModel class.
        /// </summary>
        public InfoOKResponseModelModelModelModel(IList<object> comments, ObjsFile file, ObjsPaging paging)
        {
            Comments = comments;
            File = file;
            Paging = paging;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for InfoOKResponseModelModelModelModel class.
        /// </summary>
        static InfoOKResponseModelModelModelModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public IList<object> Comments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "file")]
        public ObjsFile File { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "paging")]
        public ObjsPaging Paging { get; set; }

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
            if (Comments == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Comments");
            }
            if (File == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "File");
            }
            if (Paging == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Paging");
            }
            if (File != null)
            {
                File.Validate();
            }
            if (Paging != null)
            {
                Paging.Validate();
            }
        }
    }
}
