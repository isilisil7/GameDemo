using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class SatisManager : ISatisService
    {
        public void KampanyaliSatis(Customer customer, Oyun oyun, Kampanya kampanya)
        {
            Console.WriteLine(oyun.OyunAd + " oyunu, " + kampanya.KampanyaAdi + " kampanyasi ile " + customer.Ad + " " + customer.Soyad +" isimli oyuncuya satildi.");
        }

        public void Sat(Customer customer, Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAd + " oyunu, " + customer.Ad + " isimli oyuncuya satildi.");
        }


    }
}
