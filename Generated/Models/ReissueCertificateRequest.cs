// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DigiCertSharp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReissueCertificateRequest
    {
        /// <summary>
        /// Initializes a new instance of the ReissueCertificateRequest class.
        /// </summary>
        public ReissueCertificateRequest()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReissueCertificateRequest class.
        /// </summary>
        /// <param name="csr">Certificate Signing Request.</param>
        /// <param name="commonName">The name to be secured in the
        /// certificate.</param>
        /// <param name="sans">Subject Alternative Names. A comma delimited
        /// list of names to be secured in the certificate.</param>
        /// <param name="serverType">Server platform. Defaults to server_type
        /// of order.</param>
        /// <param name="comments">Notes about this order for customer's
        /// internal use.</param>
        public ReissueCertificateRequest(string csr = default(string), string commonName = default(string), string sans = default(string), string serverType = default(string), string comments = default(string))
        {
            Csr = csr;
            CommonName = commonName;
            Sans = sans;
            ServerType = serverType;
            Comments = comments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets certificate Signing Request.
        /// </summary>
        [JsonProperty(PropertyName = "csr")]
        public string Csr { get; set; }

        /// <summary>
        /// Gets or sets the name to be secured in the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "common_name")]
        public string CommonName { get; set; }

        /// <summary>
        /// Gets or sets subject Alternative Names. A comma delimited list of
        /// names to be secured in the certificate.
        /// </summary>
        [JsonProperty(PropertyName = "sans")]
        public string Sans { get; set; }

        /// <summary>
        /// Gets or sets server platform. Defaults to server_type of order.
        /// </summary>
        [JsonProperty(PropertyName = "server_type")]
        public string ServerType { get; set; }

        /// <summary>
        /// Gets or sets notes about this order for customer's internal use.
        /// </summary>
        [JsonProperty(PropertyName = "comments")]
        public string Comments { get; set; }

    }
}
