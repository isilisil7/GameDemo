using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class CustomerManager : ICustomerService
    {
        private ICustomerCheckService _customerCheckService;
        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public void Ekle(Customer customer)
        {
            if (_customerCheckService.checkIfRealPerson(customer))
            {
                Console.WriteLine(customer.Ad + " " + customer.Soyad + " kişisi sisteme eklendi.");
            }
            else
            {
                throw new Exception("Not a valid person.");
            }
        }

        public void Guncelle(Customer customer)
        {
            Console.WriteLine(customer.Ad + " " + customer.Soyad + " kişisinin bilgileri güncellendi.");
        }

        public void Sil(Customer customer)
        {
            Console.WriteLine(customer.Ad + " " + customer.Soyad + " kişisi sistemden silindi.");
        }
    }
}
