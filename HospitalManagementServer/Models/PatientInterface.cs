namespace HospitalManagementServer.Models
{
    public interface IPatient
    {
        public Guid ID { get; set; }

        public string Name { get; set; }

        public List<Address> Addresses { get; set; }

        public decimal BillAmount { get; set; }

        public string Code { get; set; }

        public long Phone { get; set; }
    }
}
