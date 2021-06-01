using System;

namespace LabApp4.Domain
{
    public class Farmer : Human
    {
        public Guid DriverLicenseId { get; set; }

        public Farmer(int id, string firstName, string lastName, string birthday) : base(id, firstName, lastName,
            birthday)
        {
        }

        public void GetDriverLicense()
        {
            DriverLicenseId = Guid.NewGuid();
        }
    }
}