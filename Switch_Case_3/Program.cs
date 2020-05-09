using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Case_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yetki giriniz: ");
            string yetki = Console.ReadLine();
            switch (yetki)
            {
                case "Admin":
                case "Yönetici":
                case "Başkan":
                case "Ceo":
                    Console.Write("Yönetim paneline yönlendiriliyorsunuz.");
                    break;
                case "Üye":
                    Console.Write("Ana sayfaya yönlendiriliyorsunuz.");
                    break;
                default:
                    Console.Write("Bu sayfayı görmek için yetkiniz yok.");
                    break;
            }
            Console.ReadKey();
        }
    }
}
// Kullanıcıdan yetkisinin ne olduğunu öğrenen ve ona göre yönlendirme yapan program. Yetkiler: admin, yönetici, başkan, ceo. Bunlar yönetim paneline        yönlendirilecek. Üye ana sayfaya yönlendirilecek. Geçerli yetki yoksa uyarı verilecek.