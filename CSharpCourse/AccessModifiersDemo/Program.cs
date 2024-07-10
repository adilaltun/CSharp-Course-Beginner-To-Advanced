using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessModifiers;

namespace AccessModifiersDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Course nesnesini AccessModifiers projesinden çektik. Peki bunu nasıl yaptık. AccessModifiersDemo içerisine geldiğinde references kısmında 
            // AccessModifiers sınıfını oraya (reference kısmına) ekledik. ardından using AccessModifier diyerek import işlemini sağladık. 
            // Burada önemli olan nokta nesnesi oluşturulacak sınıfın public anahtar kelimesi almasıdır.

            Course course = new Course();

        }
    }
}
