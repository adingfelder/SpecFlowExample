using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestSpecFlow.PageObjects.CustomerDetails
{
    public class Customer1
    {
        public String firstName = "Andrew";
        String lastName = "Daniels";
        String company = "Planit";
        String address = "13 Armstrong street";
        String city = "Houston";
        String state = "Texas";
        String zipCode = "00000";
        String mobile_num = "213012301230";
        String address_assign = "My 2nd Address";

        public String getFirstName() {
            return firstName;
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
