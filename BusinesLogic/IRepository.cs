using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogic
{
    // Bir sınıfı belli alan ve davranışlara zorlamakta kullandığımız yapıdır.
    // Absctracttan en önemli farkı miras almaya sayı sınırına takılma.
    //İçinde access modifier tanımlayamayız çünkü herşey default publictir.
    // Interface değişken tipi olarak kullanılabilir.
    interface IRepository<T>
    {

        void Ekle(T eklenecekSey ); //Sadece method signature (imzası) tanımlanabilir. Gövdesi tanımlanamaz.
        void Sil(T silinecekSey);  // Method imzası 
    }
}
