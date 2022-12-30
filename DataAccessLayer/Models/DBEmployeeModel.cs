using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemHR.DataAccessLayer.Models
{
    public class DBEmployeeModel
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Code { get; set; }
        public string Gender { get; set; }
        public string DateBirth { get; set; }
        public string PESEL { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAdress { get; set; }
        public string IdentityCardNumber { get; set; }
        public string IssueDateIdentityCard { get; set; }
        public string ExpirationDateIdentityCard { get; set; }
        public string PassportNumber { get; set; }
        public string IssueDateIdentityPassport { get; set; }
        public string ExpirationDateIdentityPassport { get; set; }
        public string Status { get; set; }
        public string Position { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
    }
}
