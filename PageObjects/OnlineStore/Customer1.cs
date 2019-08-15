using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumShoppingCart.ScreenModel
{
    public class Customer1
    {
        string email = "dandrew355@planit.com";
        string password = "Henscrow123";
        string firstName = "Andrew";
        string lastName = "Daniels";
        string company = "Planit";
        string address = "13 Armstrong street";
        string city = "Houston";
        string state = "Texas";
        string zipCode = "00000";
        string mobile_num = "213012301230";
        string address_assign = "My 2nd Address";
        string DOB_day = "1";
        string DOB_month = "March";
        string DOB_year = "2019";
          
        public string getDOB_day()  
        {
            return DOB_day;
        }
        public string getDOB_month()
        {
            return DOB_month;
        }
        public string getDOB_year()
        {
            return DOB_year;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getEmail()
        {
            return email;
        }
        public string getPassword()
        {
            return password;
        }

        public string getLastName()
        {
            return lastName;
        }

        public string getCompany()
        {
            return company;
        }

        public string getAddress()
        {
            return address;
        }

        public string getCity()
        {
            return city;
        }

        public string getState()
        {
            return state;
        }

        public string getZip()
        {
            return zipCode;
        }

        public string getMobile()
        {
            return mobile_num;
        }

        public string getAssign()
        {
            return address_assign;
        }



    }
}
