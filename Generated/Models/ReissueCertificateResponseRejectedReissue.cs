// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DigiCertSharp.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Details of the rejected reissue (if any) are listed here.
    /// </summary>
    public partial class ReissueCertificateResponseRejectedReissue
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ReissueCertificateResponseRejectedReissue class.
        /// </summary>
        public ReissueCertificateResponseRejectedReissue()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ReissueCertificateResponseRejectedReissue class.
        /// </summary>
        /// <param name="commonName">The Common Name of the rejected reissue
        /// request.</param>
        /// <param name="sans">The list of SANs in the rejected
        /// reissue.</param>
        public ReissueCertificateResponseRejectedReissue(string commonName = default(string), IList<string> sans = default(IList<string>))
        {
            CommonName = commonName;
            Sans = sans;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Common Name of the rejected reissue request.
        /// </summary>
        [JsonProperty(PropertyName = "common_name")]
        public string CommonName { get; set; }

        /// <summary>
        /// Gets or sets the list of SANs in the rejected reissue.
        /// </summary>
        [JsonProperty(PropertyName = "sans")]
        public IList<string> Sans { get; set; }

    }
}