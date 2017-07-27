namespace DigiCertSharp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ReissueCertificateResponse
    {
        public bool IsRejected
        {
            get
            {
                return RejectedReissue != null && (
                    !string.IsNullOrEmpty(RejectedReissue.CommonName) ||
                    (RejectedReissue.Sans != null && RejectedReissue.Sans.Count > 0)
                );
            }
        }
    }
}