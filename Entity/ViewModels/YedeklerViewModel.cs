using Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.ViewModels;

namespace Entity.ViewModels
{
   public class YedeklerViewModel
    {
        public List<CariHesap> CariYedek { get; set; }
        public List<Grup> GrupYedek { get; set; }
        public List<HesapHareket> HesapYedek { get; set; }
    }
}
