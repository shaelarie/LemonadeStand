using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Customer customer = new Customer();
        public CustomerList ListOfCustomers = new CustomerList();
        public Endings ending = new Endings();
        public Weather weather = new Weather();
        public int startDay = 1;
        public int days = 7;
        public int customerNumber = 0;
        public Recipe recipe = new Recipe();
        Random randomGen = new Random();

    }
}
