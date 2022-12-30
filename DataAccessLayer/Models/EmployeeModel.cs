using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models.Dictonaries;

namespace SystemHR.DataAccessLayer.Models
{
    public class EmployeeModel : EntityModel
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Code { get; set; }
        public GenderModel Gender { get; set; }
        public DateTime? DateBirth { get; set; }
        public string PESEL { get; set; }   
        public string PhoneNumber { get; set; } 
        public string EmailAdress { get; set; }  
        public string IdentityCardNumber { get; set; }  
        public DateTime? IssueDateIdentityCard { get; set; }    
        public DateTime? ExpirationDateIdentityCard { get; set; }
        public string PassportNumber { get; set; }
        public DateTime? IssueDateIdentityPassport{ get; set; }
        public DateTime? ExpirationDateIdentityPassport { get; set; }
        public StatusModel Status { get; set; }
        public PositionModel Position { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
