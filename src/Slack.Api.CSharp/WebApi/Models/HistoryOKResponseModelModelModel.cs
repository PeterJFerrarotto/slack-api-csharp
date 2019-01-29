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
    /// im.history success schema
    /// </summary>
    /// <remarks>
    /// Schema for successful response from im.history method
    /// </remarks>
    public partial class HistoryOKResponseModelModelModel
    {
        /// <summary>
        /// Initializes a new instance of the HistoryOKResponseModelModelModel
        /// class.
        /// </summary>
        public HistoryOKResponseModelModelModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HistoryOKResponseModelModelModel
        /// class.
        /// </summary>
        public HistoryOKResponseModelModelModel(bool hasMore, IList<ObjsMessage> messages)
        {
            HasMore = hasMore;
            Messages = messages;
            CustomInit();
        }
        /// <summary>
        /// Static constructor for HistoryOKResponseModelModelModel class.
        /// </summary>
        static HistoryOKResponseModelModelModel()
        {
            Ok = true;
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "has_more")]
        public bool HasMore { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public IList<ObjsMessage> Messages { get; set; }

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
            if (Messages == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Messages");
            }
            if (Messages != null)
            {
                if (Messages.Count < 1)
                {
                    throw new ValidationException(ValidationRules.MinItems, "Messages", 1);
                }
                if (Messages.Count != System.Linq.Enumerable.Count(System.Linq.Enumerable.Distinct(Messages)))
                {
                    throw new ValidationException(ValidationRules.UniqueItems, "Messages");
                }
                foreach (var element in Messages)
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
