using proje2Form.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Controllers
{
    class CustomerController
    {
        List<Customer> customers = new List<Customer>();
        int lastid = 1000;

        public void CreateCustomer(string name, string surname)
        {
            Customer customer = new Customer();
            customer.Name = name;
            customer.Surname = surname;
            customers.Add(customer);
        }
    }
}
