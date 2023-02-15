namespace Session_27.Model {
    public class Customer
    {
        public Customer(string name, string surname, int phone, string tin)
        {
            Name = name;
            Surname = surname;
            Phone = phone;
            Tin = tin;

            Transactions = new List<Transaction>();
        }

        public Customer()
        {

        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Phone { get; set; }
        public string Tin { get; set; }

        // Relations
        public List<Transaction> Transactions { get; set; }
        public string FullName {
            get {
                return string.Format("{0} {1}", Name, Surname);
            }
        }
    }
}
