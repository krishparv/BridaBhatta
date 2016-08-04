using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LFA.Forum.DAL.Ado;
using System.Data.SqlClient;
using BridaBhatta.Bll.Model;


namespace BridaBhatta.Bll
{
    public class AdultPerson
    {
        private SqlHelper _sqlhp;
        public AdultPerson()
        {
            _sqlhp = new SqlHelper();
        }

        public int CalculateAge(DateTime dob)
        {
            
            var year = DateTime.Parse(dob.ToShortDateString()).Year;
            var todayYear = DateTime.Now.Year;
            var age = todayYear - year;
            return age;                  
           
        }

      public double calculateAmount(int age)
        {
            if (age > 70 && age < 80)
            {
                return 500;
            }

            else if (age > 80)
            {
                return 1000;
            }

            else
            {
                return 0;
            }
        }
        public List<AdultPersonModel> GetAllData()
        {
            List<AdultPersonModel> LsPerson = new List<AdultPersonModel>();
            string query = "Select * from AdultPerson";
            SqlDataReader sql= _sqlhp.ExecuteReader(query);
            while(sql.Read())
            {
                AdultPersonModel person = new AdultPersonModel();
                person.Id =int.Parse(sql["Id"].ToString());
                person.FirstName = sql["FirstName"].ToString();
                person.LastName = sql["LastName"].ToString();
                person.DOB = DateTime.Parse(sql["DOB"].ToString());
                person.Age = int.Parse(sql["Age"].ToString());
                person.Amount =decimal.Parse(sql["Amount"].ToString());
                person.Address = sql["Address"].ToString();
                person.Street = sql["Street"].ToString();
                LsPerson.Add(person);
            }
            sql.Close();
            return LsPerson;
        }

        public AdultPersonModel GetDataById(int id)
        {
            string query = "Select * from AdultPerson where Id=@id";
            SqlDataReader sql= _sqlhp.ExecuteReader(query, "@id", id);
            AdultPersonModel person = new AdultPersonModel();
            while(sql.Read())
            {
                person.FirstName = sql["FirstName"].ToString();
                person.LastName = sql["LastName"].ToString();
                person.DOB = DateTime.Parse(sql["DOB"].ToString());
                person.Age = int.Parse(sql["Age"].ToString());
                person.Amount = decimal.Parse(sql["Amount"].ToString());
                person.Address = sql["Address"].ToString();
                person.Street = sql["Street"].ToString();
            }
            sql.Close();
            return person;
        }

        public int AddPersonDetails(AdultPersonModel person)
        {
            SqlParameter [] param=new SqlParameter[]
            {
                new SqlParameter("@FirstName",person.FirstName),
                new SqlParameter("@LastName",person.LastName),
                new SqlParameter("@DOB",person.DOB),
                new SqlParameter("@Age",person.Age),
                new SqlParameter("@Amount",person.Amount),
                new SqlParameter("@Address",person.Address),
                new SqlParameter("@Street",person.Street)
            
            };
            string query="usp_AddPerson";

           return _sqlhp.ExecuteNonQueryProc(query, param);
        }
    }
}
