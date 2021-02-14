using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface ICustomerService
    {
        void Ekle(Customer customer);
        void Guncelle(Customer customer);
        void Sil(Customer customer);
    }
}
