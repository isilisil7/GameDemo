using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    public class KampanyaManager : IKampanyaService
    {
        public void Ekle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " sisteme " + kampanya.KampanyaOrani + " oranında eklendi.");
        }

        public void Guncelle(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " sistemde " + kampanya.KampanyaOrani + " oranı olarak güncellendi.");
        }

        public void Sil(Kampanya kampanya)
        {
            Console.WriteLine(kampanya.KampanyaAdi + " sistemden silindi.");
        }
    }
}
