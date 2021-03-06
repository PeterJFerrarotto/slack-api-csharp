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
    /// im.list success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response im.list method
    /// </remarks>
    public partial class ListOKResponseModelModelModelModelModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ListOKResponseModelModelModelModelModelModelModel class.
        /// </summary>
        public ListOKResponseModelModelModelModelModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ListOKResponseModelModelModelModelModelModelModel class.
        /// </summary>
        public ListOKResponseModelModelModelModelModelModelModel(IList<ObjsIm> ims)
        {
            Ims = ims;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for
        /// ListOKResponseModelModelModelModelModelModelModel class.
        /// </summary>
        static ListOKResponseModelModelModelModelModelModelModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ims")]
        public IList<ObjsIm> Ims { get; set; }

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
            if (Ims == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Ims");
            }
            if (Ims != null)
            {
                if (Ims.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Ims)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Ims");
                }
                foreach (var element in Ims)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
