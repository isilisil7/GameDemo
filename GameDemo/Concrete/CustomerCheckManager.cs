using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool checkIfRealPerson(Customer customer)
        {
            if (customer.DogumYili == 2020 && customer.Ad == "Işıl" && customer.Soyad == "Özkaynak" && customer.TcNo == "123456789")
            {
                return true;
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }

    }
}
