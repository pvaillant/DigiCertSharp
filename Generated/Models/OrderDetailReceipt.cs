// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DigiCertSharp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Once the certificate has been issued, a receipt is generated
    /// </summary>
    public partial class OrderDetailReceipt
    {
        /// <summary>
        /// Initializes a new instance of the OrderDetailReceipt class.
        /// </summary>
        public OrderDetailReceipt()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderDetailReceipt class.
        /// </summary>
        /// <param name="orderTotal">The total paid for the order</param>
        public OrderDetailReceipt(double? orderTotal = default(double?))
        {
            OrderTotal = orderTotal;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the total paid for the order
        /// </summary>
        [JsonProperty(PropertyName = "order_total")]
        public double? OrderTotal { get; set; }

    }
}
