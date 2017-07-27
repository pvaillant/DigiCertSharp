namespace DigiCertSharp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OrderDetailCertificateDetails
    {
        private const string PENDING_ISSUANCE = "pending issuance";
        private const string ISSUED = "issued";
        private const string MULTI_DOMAIN_SSL = "Multi-Domain SSL";

        public bool IsIssued
        {
            get { return string.Equals(ISSUED, Status); }
        }

        public bool IsMultiDomain
        {
            get { return string.Equals(MULTI_DOMAIN_SSL, ProductName); }
        }

        public bool IsPendingIssuance
        {
            get { return string.Equals(PENDING_ISSUANCE, Status); }
        }

        public int ValidityYears {
            get { return int.Parse(Validity.Substring(0, 1)); }
        }
    }
}