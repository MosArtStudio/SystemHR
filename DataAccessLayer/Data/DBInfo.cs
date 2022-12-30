using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models.Dictonaries;
using SystemHR.DataAccessLayer.Models;
using System.Configuration;

namespace SystemHR.DataAccessLayer.Data
{
    public class DBInfo
    {
        [PrimaryKey,AutoIncrement]
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


        DBInfo() { }

        public static string LoadConnecionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public DBInfo(EmployeeModel employee)
        {
            Id = employee.Id;
            LastName = employee.LastName;
            FirstName = employee.FirstName;
            Code = employee.Code;
            Gender = employee.Gender != null ? employee.Gender.Value : null;
            DateBirth = Convert.ToString(employee.DateBirth);
            PESEL = employee.PESEL;
            PhoneNumber = employee.PhoneNumber;
            EmailAdress = employee.EmailAdress;
            IdentityCardNumber = employee.IdentityCardNumber;
            IssueDateIdentityCard = Convert.ToString(employee.IssueDateIdentityCard);
            ExpirationDateIdentityCard = Convert.ToString(employee.ExpirationDateIdentityCard);
            PassportNumber = employee.PassportNumber;
            IssueDateIdentityPassport = Convert.ToString(employee.IssueDateIdentityPassport);
            ExpirationDateIdentityPassport = Convert.ToString(employee.ExpirationDateIdentityPassport);
            Status = Convert.ToString(employee.Status);
            Position = Convert.ToString(employee.Position);
            StartDate = Convert.ToString(employee.StartDate);
            EndDate = Convert.ToString(employee.EndDate);
        }
    }
}
