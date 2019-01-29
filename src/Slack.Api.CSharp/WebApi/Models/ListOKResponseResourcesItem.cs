// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ListOKResponseResourcesItem
    {
        /// <summary>
        /// Initializes a new instance of the ListOKResponseResourcesItem
        /// class.
        /// </summary>
        public ListOKResponseResourcesItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ListOKResponseResourcesItem
        /// class.
        /// </summary>
        /// <param name="id">An ID for a resource</param>
        /// <param name="type">The type of resource the `id` corresponds
        /// to</param>
        public ListOKResponseResourcesItem(string id = default(string), string type = default(string))
        {
            Id = id;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets an ID for a resource
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the type of resource the `id` corresponds to
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}