// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DigiCertSharp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// CertificateOrderResponse
    /// </summary>
    public partial class OrderCertificateCreatedResponse
    {
        /// <summary>
        /// Initializes a new instance of the OrderCertificateCreatedResponse
        /// class.
        /// </summary>
        public OrderCertificateCreatedResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderCertificateCreatedResponse
        /// class.
        /// </summary>
        public OrderCertificateCreatedResponse(string orderId = default(string))
        {
            OrderId = orderId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "order_id")]
        public string OrderId { get; set; }

    }
}
