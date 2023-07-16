namespace HospitalClassLibrary
{   interface IPatient
    {
        public int ID { get; set; }
        public decimal BillAmount { get; set; }
        public string Code { get; set; }



    }
    public class Patient:IPatient
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public List<Address> Addresses { get; set; }

        public decimal BillAmount { get; set; }

        public string Code { get; set; }

    }

    public class Address
    {
        public string TemporaryAddress { get; set; }

        public string PermanentAddress { get; set; }


    }
}