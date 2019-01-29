// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Slack.Api.CSharp.WebApi.Models
{
    using Microsoft.Rest;

    /// <summary>
    /// Exception thrown for an invalid response with EditErrorModel
    /// information.
    /// </summary>
    public partial class EditErrorModelException : RestException
    {
        /// <summary>
        /// Gets information about the associated HTTP request.
        /// </summary>
        public HttpRequestMessageWrapper Request { get; set; }

        /// <summary>
        /// Gets information about the associated HTTP response.
        /// </summary>
        public HttpResponseMessageWrapper Response { get; set; }

        /// <summary>
        /// Gets or sets the body object.
        /// </summary>
        public EditErrorModel Body { get; set; }

        /// <summary>
        /// Initializes a new instance of the EditErrorModelException class.
        /// </summary>
        public EditErrorModelException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the EditErrorModelException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        public EditErrorModelException(string message)
            : this(message, null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the EditErrorModelException class.
        /// </summary>
        /// <param name="message">The exception message.</param>
        /// <param name="innerException">Inner exception.</param>
        public EditErrorModelException(string message, System.Exception innerException)
            : base(message, innerException)
        {
        }
    }
}