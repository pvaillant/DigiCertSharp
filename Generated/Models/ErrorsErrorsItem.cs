// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DigiCertSharp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ErrorsErrorsItem
    {
        /// <summary>
        /// Initializes a new instance of the ErrorsErrorsItem class.
        /// </summary>
        public ErrorsErrorsItem()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ErrorsErrorsItem class.
        /// </summary>
        public ErrorsErrorsItem(string code = default(string), string description = default(string))
        {
            Code = code;
            Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

    }
}
