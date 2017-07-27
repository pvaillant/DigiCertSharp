// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DigiCertSharp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class IssuedCertificate
    {
        /// <summary>
        /// Initializes a new instance of the IssuedCertificate class.
        /// </summary>
        public IssuedCertificate()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IssuedCertificate class.
        /// </summary>
        /// <param name="orderId">Unique identifier for certificate
        /// order.</param>
        /// <param name="serial">The serial Number of the Certificate</param>
        /// <param name="certs">A data set containing the certificates</param>
        public IssuedCertificate(int? orderId = default(int?), string serial = default(string), IssuedCertificateCerts certs = default(IssuedCertificateCerts))
        {
            OrderId = orderId;
            Serial = serial;
            Certs = certs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets unique identifier for certificate order.
        /// </summary>
        [JsonProperty(PropertyName = "order_id")]
        public int? OrderId { get; set; }

        /// <summary>
        /// Gets or sets the serial Number of the Certificate
        /// </summary>
        [JsonProperty(PropertyName = "serial")]
        public string Serial { get; set; }

        /// <summary>
        /// Gets or sets a data set containing the certificates
        /// </summary>
        [JsonProperty(PropertyName = "certs")]
        public IssuedCertificateCerts Certs { get; set; }

    }
}