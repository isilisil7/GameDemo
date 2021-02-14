using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameDemo.Abstract
{
    interface ISatisService
    {
        void Sat(Customer customer, Oyun oyun);
        void KampanyaliSatis(Customer customer, Oyun oyun, Kampanya kampanya);
    }
}
