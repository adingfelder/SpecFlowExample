using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumShoppingCart.ScreenModel
{
    public class Customer1
    {
        String email = "dandrew@planit.com";
        String password = "Henscrow123";
        String firstName = "Andrew";
        String lastName = "Daniels";
        String company = "Planit";
        String address = "13 Armstrong street";
        String city = "Houston";
        String state = "Texas";
        String zipCode = "00000";
        String mobile_num = "213012301230";
        String address_assign = "My 2nd Address";
        String DOB_day = "1";
        String DOB_month = "March";
        String DOB_year = "2019";

        public String getDOB_day()
        {
            return DOB_day;
        }
        public String getDOB_month()
        {
            return DOB_month;
        }
        public String getDOB_year()
        {
            return DOB_year;
        }
        public String getFirstName()
        {
            return firstName;
        }
        public String getEmail()
        {
            return email;
        }
        public String getPassword()
        {
            return password;
        }

        public String getLastName()
        {
            return lastName;
        }

        public String getCompany()
        {
            return company;
        }

        public String getAddress()
        {
            return address;
        }

        public String getCity()
        {
            return city;
        }

        public String getState()
        {
            return state;
        }

        public String getZip()
        {
            return zipCode;
        }

        public String getMobile()
        {
            return mobile_num;
        }

        public String getAssign()
        {
            return address_assign;
        }



    }
}
