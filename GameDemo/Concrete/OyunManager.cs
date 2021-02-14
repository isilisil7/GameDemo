using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Concrete
{
    class OyunManager : IOyunService
    {
        public void Ekle(Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAd + " oyunu sisteme eklendi. Fiyatı: " + oyun.Fiyati);
        }

        public void Guncelle(Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAd + " oyunun bilgileri güncellendi.");
        }

        public void Sil(Oyun oyun)
        {
            Console.WriteLine(oyun.OyunAd + " oyunu sistemden silindi.");
        }
    }
}
