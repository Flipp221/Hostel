using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel
{
    public class ContactPhone
    {
        public string PublicPhone { get; set; }
    }

    public class GeoData
    {
        public List<double> Coordinates { get; set; }
        public string Type { get; set; }
    }

    public class GeodataCenter
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class Root
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Global_id { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string LegalAddress { get; set; }
        public List<ContactPhone> ContactPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }
        public string Categorization { get; set; }
        public string CertificateNumber { get; set; }
        public string CertificateIssueDate { get; set; }
        public string NumberInFederalList { get; set; }
        public string CertificateValidity { get; set; }
        public string NameOfAccreditedOrganization { get; set; }
        public GeoData GeoData { get; set; }
        public GeodataCenter Geodata_center { get; set; }
    }
}
