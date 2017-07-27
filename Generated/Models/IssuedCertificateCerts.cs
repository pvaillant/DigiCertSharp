// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace DigiCertSharp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A data set containing the certificates
    /// </summary>
    public partial class IssuedCertificateCerts
    {
        /// <summary>
        /// Initializes a new instance of the IssuedCertificateCerts class.
        /// </summary>
        public IssuedCertificateCerts()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IssuedCertificateCerts class.
        /// </summary>
        /// <param name="certificate">The certificate</param>
        /// <param name="intermediate">The intermediate certificate</param>
        /// <param name="root">The root certificate</param>
        /// <param name="pkcs7">PKCS7 of the certificates</param>
        public IssuedCertificateCerts(string certificate = default(string), string intermediate = default(string), string root = default(string), string pkcs7 = default(string))
        {
            Certificate = certificate;
            Intermediate = intermediate;
            Root = root;
            Pkcs7 = pkcs7;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the certificate
        /// </summary>
        [JsonProperty(PropertyName = "certificate")]
        public string Certificate { get; set; }

        /// <summary>
        /// Gets or sets the intermediate certificate
        /// </summary>
        [JsonProperty(PropertyName = "intermediate")]
        public string Intermediate { get; set; }

        /// <summary>
        /// Gets or sets the root certificate
        /// </summary>
        [JsonProperty(PropertyName = "root")]
        public string Root { get; set; }

        /// <summary>
        /// Gets or sets PKCS7 of the certificates
        /// </summary>
        [JsonProperty(PropertyName = "pkcs7")]
        public string Pkcs7 { get; set; }

    }
}