﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
   public class CariHesap
    {
        public int CariKod { get; set; }
        public string Unvan { get; set; }
        public byte[] FirmaLogo { get; set; }
        public Grup Grup { get; set; }  // Genel tabındaki özellikler aşağıdakiler ise diğer tablardaki özellikleri ekleyebilmek için o classlardan değişken tanımladık.


        public Banka Banka { get; set; }
        public Iletisim Iletisim { get; set; }
        public Ticari Ticari { get; set; }
        public Kefil Kefil { get; set; }
    }
}
