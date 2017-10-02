using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Models
{
    public abstract class Contact  // Yalnızca ortak alanlar için oluşturulmuş bir clas, tam bir varlık değil.
    {
        public string Adres { get; set; }
        public Sehir Sehir { get; set; }
        public Ilce Ilce { get; set; }
        public string Tel { get; set; }
        public string CepTel { get; set; }
    }
}
