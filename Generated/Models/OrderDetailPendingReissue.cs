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
    /// If there is a pending reissue, this section will be populated.
    /// </summary>
    public partial class OrderDetailPendingReissue
    {
        /// <summary>
        /// Initializes a new instance of the OrderDetailPendingReissue class.
        /// </summary>
        public OrderDetailPendingReissue()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OrderDetailPendingReissue class.
        /// </summary>
        /// <param name="commonName">The Common Name in the current pending
        /// reissue.</param>
        /// <param name="sans">A collection that contains one or more SANs, (if
        /// any).</param>
        public OrderDetailPendingReissue(string commonName = default(string), IList<string> sans = default(IList<string>))
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
        /// Gets or sets the Common Name in the current pending reissue.
        /// </summary>
        [JsonProperty(PropertyName = "common_name")]
        public string CommonName { get; set; }

        /// <summary>
        /// Gets or sets a collection that contains one or more SANs, (if any).
        /// </summary>
        [JsonProperty(PropertyName = "sans")]
        public IList<string> Sans { get; set; }

    }
}