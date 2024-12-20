namespace PrimeiraAPI.ViewModel
{
    public class CustomerViewModel
    {     
        public required bool NameStyle { get; set; }

        public string? Title { get; set; }

        public required string FirstName { get; set; }

        public string? MiddleName { get; set; }

        public required string LastName { get; set; }

        public string? Suffix { get; set; }

        public string? CompanyName { get; set; }

        public string? SalesPerson { get; set; }

        public string? EmailAddress { get; set; }

        public string? Phone { get; set; }

        public string? PasswordHash { get; set; }

        public string? PasswordSalt { get; set; }     

        public DateTime? ModifiedDate { get; set; }
    }
}
