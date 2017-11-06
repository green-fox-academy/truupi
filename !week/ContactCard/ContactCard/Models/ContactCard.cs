namespace ContactCardApp.Models
{
    public class ContactCard
    {
        public int Id { get; set; }
        public int CardStyle { get; set; }
        public string ImageLink { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Job { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNum { get; set; }
        public string WebAdress { get; set; }
        public string EmailAddress { get; set; }
        public string FacebookLink { get; set; }
        public string LinkedInLink { get; set; }
        public string TwitterLink { get; set; }
    }
}
