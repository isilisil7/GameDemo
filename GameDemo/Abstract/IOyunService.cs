using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface IOyunService
    {
        void Ekle(Oyun oyun);
        void Guncelle(Oyun oyun);
        void Sil(Oyun oyun);
    }
}
