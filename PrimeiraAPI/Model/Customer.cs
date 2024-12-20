using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PrimeiraAPI.Model
{
    [Table("Customer", Schema = "SalesLT")]
    public class Customer
    {
        public Customer() { } // Construtor sem parâmetros, necessário para o EF

        public Customer(bool nameStyle, string title, string firstName, string middleName, string lastName, string suffix, string companyName, string salesPerson, string emailAddress, string phone, string passwordHash, string passwordSalt, DateTime? modifiedDate)
        {
            NameStyle = nameStyle;
            Title = title;
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Suffix = suffix;
            CompanyName = companyName;
            SalesPerson = salesPerson;
            EmailAddress = emailAddress;
            Phone = phone;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;            
            ModifiedDate = modifiedDate;
        }

        [Key] // Define CustomerID como a chave primária        
        public int CustomerID { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string CompanyName { get; set; }
        public string SalesPerson { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }        
        public DateTime? ModifiedDate { get; set; }
    }


}
