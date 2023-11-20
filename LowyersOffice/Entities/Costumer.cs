namespace LowyersOffice.Entities
{
    public class Costumer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        public string Whatsapp { get; set; }

        public Costumer(int id, string firstName, string lastName, string address,
            string phone, string email, string whatsapp)
        {
            this.Id = id;
            this.FirstName=firstName;
            this.LastName=lastName;
            this.Address=address;
            this.PhoneNumber=phone;
            this.Email=email;
            this.Whatsapp = whatsapp;
        }
        public Costumer()
        {

        }
       
    }
}
