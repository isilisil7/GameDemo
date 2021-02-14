using GameDemo.Abstract;
using GameDemo.Concrete;
using GameDemo.Entities;
using System;
using System.Collections.Generic;

namespace GameDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, Ad = "Işıl", Soyad = "Özkaynak", DogumYili = 2020, TcNo = "123456789" };
            ICustomerService islem = new CustomerManager(new CustomerCheckManager());
            islem.Ekle(customer1);
            islem.Guncelle(customer1);
            islem.Sil(customer1);

            Kampanya kampanya1 = new Kampanya() { KampanyaId = 1, KampanyaAdi = "Kış kampanyası", KampanyaOrani = 25 };
            IKampanyaService kampanyaService = new KampanyaManager();
            kampanyaService.Ekle(kampanya1);
            kampanyaService.Guncelle(kampanya1);
            kampanyaService.Sil(kampanya1);

            Oyun oyun1 = new Oyun() { OyunAd="Lol", Fiyati=799, OyunId=1 };
            IOyunService oyunService = new OyunManager();
            oyunService.Ekle(oyun1);
            oyunService.Guncelle(oyun1);
            oyunService.Sil(oyun1);

            ISatisService satisService = new SatisManager();
            satisService.Sat(customer1, oyun1);
            satisService.KampanyaliSatis(customer1, oyun1, kampanya1);
        }
    }
}
