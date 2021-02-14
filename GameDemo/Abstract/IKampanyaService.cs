using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    public interface IKampanyaService
    {
        void Ekle(Kampanya kampanya);
        void Guncelle(Kampanya kampanya);
        void Sil(Kampanya kampanya);
    }
}
