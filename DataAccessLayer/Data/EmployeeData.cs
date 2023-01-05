using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemHR.DataAccessLayer.Models;
using SQLite;
using Dapper;
using System.Data;
using SystemHR.DataAccessLayer.Models.Dictonaries;
using System.IO;
using System.Reflection;

namespace SystemHR.DataAccessLayer.Data
{
    public class EmployeeData
    {
        public static IList<EmployeeModel> employeesList = new List<EmployeeModel>();
        private static SQLiteConnection db;
        //private string p = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
        public string DBpath = Path.Combine(
            Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, 
            "dataBaseHR.db");
        public EmployeeData()
        {        
            if (System.IO.File.Exists(DBpath))
            {

            }
            else
            {
                using (db = new SQLiteConnection(DBpath))
                {
                    db.CreateTable<DBInfo>();
                    db.Close();
                }                  
            }
            //LoadDataFromDatabase();
        }

        public void LoadDataFromDatabase()
        {
            using (db = new SQLiteConnection(DBpath))
            {
                var list = db.Query<DBEmployeeModel>("select * from DBInfo");
                employeesList = MapDBEmployeeModelToEmployeeModel(list);
            }
            
        }
        public static IList<EmployeeModel> MapDBEmployeeModelToEmployeeModel
            (IList<DBEmployeeModel> DBemployeesModel)
        {
            IList<EmployeeModel> employeesModel = new List<EmployeeModel>();

            foreach (DBEmployeeModel DBEmployeeModel in DBemployeesModel)
            {
                EmployeeModel employeeModel = new EmployeeModel();
                employeeModel.Id = DBEmployeeModel.Id;
                employeeModel.LastName = DBEmployeeModel.LastName;
                employeeModel.FirstName = DBEmployeeModel.FirstName;
                employeeModel.Code = DBEmployeeModel.Code;
                employeeModel.Gender = new GenderModel(DBEmployeeModel.Gender);
                employeeModel.DateBirth = Convert.ToDateTime(DBEmployeeModel.DateBirth);
                employeeModel.PESEL = DBEmployeeModel.PESEL;
                employeeModel.PhoneNumber = DBEmployeeModel.PhoneNumber;
                employeeModel.EmailAdress = DBEmployeeModel.EmailAdress;
                employeeModel.IdentityCardNumber = DBEmployeeModel.IdentityCardNumber;
                employeeModel.IssueDateIdentityCard = Convert.ToDateTime(DBEmployeeModel.IssueDateIdentityCard);
                employeeModel.ExpirationDateIdentityCard = Convert.ToDateTime(DBEmployeeModel.ExpirationDateIdentityCard);
                employeeModel.PassportNumber = DBEmployeeModel.PassportNumber;
                employeeModel.IssueDateIdentityPassport = Convert.ToDateTime(DBEmployeeModel.IssueDateIdentityPassport);
                employeeModel.ExpirationDateIdentityPassport = Convert.ToDateTime(DBEmployeeModel.ExpirationDateIdentityPassport);
                employeeModel.Status = new StatusModel(DBEmployeeModel.Status);
                employeeModel.Position = new PositionModel(DBEmployeeModel.Position);
                employeeModel.StartDate = Convert.ToDateTime(DBEmployeeModel.StartDate);
                employeeModel.EndDate = Convert.ToDateTime(DBEmployeeModel.EndDate);

                employeesModel.Add(employeeModel);
            }

            return employeesModel;
        }

    }
}
