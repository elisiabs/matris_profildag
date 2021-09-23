using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixVerifyer;

namespace Matrix
{
    partial class Program
    {
        static void Main(string[] args)
        {
            /*
             * Där finns tester tillgängliga genom att skriva
             * MatrixChecker.CheckAddition
             * MatrixChecker.CheckMultiplication
             * MatrixChecker.CheckRotationMatrix
             * 
             * Observera att testerna inte är noga testade.
             * 
             * De tar emot argument enligt följande standard:
             * CheckAddition tar emot alla Matris-värden 00, 01, 10, 11 för matris A
             * och alla Matris-värden 00, 01, 10, 11 för matris B, och den sista är
             * då det uträknade resultatet av A + B, som då är en matris 00, 01, 10, 11
             * 
             * CheckMultiplication liknar CheckAddition, den tar emot tre matriser,
             * A, B och sedan resultatet av A * B. Sen kommer den att jämföra och se
             * ifall matrisen har blivit rätt
             * 
             * CheckRotationMatrix tar emot antalet radianer du roterat en matris av,
             * och sedan en rotationsmatris som du har skapat. Den jämför sedan värden
             * för att se ifall matriserna stämmer överens.
             */

            /*
             * Där finns ett inbyggt verktyg för att rita ut matriser i två format.
             * Den första tar emot alla matrisvärden, 00, 01, 10, 11 och den andra
             * tar emot en float[,] (en float 2D-array) och skriver sedan ut matrisen
             * formaterat, och endast med 2 decimaler.
             */

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A + B
            // Exempel: MatrixChecker.CheckAddition(1, 2, 3, 4, 1, 2, 3, 4, 2, 4, 6, 8);

            // De fyra första siffrorna = Matris A, de nästa fyra siffrorna = Matris B, de sista fyra siffrorna = resultatet av A * B
            // Exempel: MatrixChecker.CheckMultiplication(1, 2, 3, 4, 1, 2, 3, 4, 7, 10, 15, 22);


            // Byt ut detta anropet med dina matrisvärden, så kommer programmet att rita ut dem istället :)
            

            float a00=1, a01=2, a10=3, a11=4; //Matris A
            float b00=3, b01=4, b10=5, b11=6; //Matris B
            float c00, c01, c10, c11; //Matris c (aka summan av A och B)
            float radians; //Radianerna

            float C = c00 = a00 + b00; c01 = a01 + b01; c10 = a10 + b10; c11 = a11 + b11;

            MatrixChecker.CheckAddition(a00, a01, a10, a11, b00, b01, b10, b11, c00, c01, c10, c11);
            Draw2x2Matrix(c00, c01, c10, c11);


            
            Console.WriteLine("");

            radians = 3.14f;
            float ra00, ra01, ra10, ra11; //matrisen

            float rA = ra00 = (float)Math.Cos(radians); ra01 = (float)Math.Sin(radians); ra10 = (float)Math.Sin(-radians); ra11 = (float)Math.Cos(radians);
            MatrixChecker.CheckRotationMatrix(radians, ra00, ra01, ra10, ra11);
            Draw2x2Matrix(ra00, ra01, ra10, ra11);



            float ma00 = 1, ma01 = 2, ma10 = 3, ma11 = 4; //Matris A
            float mb00 = 5, mb01 = 6, mb10 = 7, mb11 = 8; //Matris B
            float mc00, mc01, mc10, mc11; //Matris C (aka produkten av A och B)

            float mC = mc00 = (ma00 * mb00) + (ma01*mb10); mc01 = (ma00 * mb01) + (ma01*mb11); mc10 = (ma10 * mb00) +(ma11*mb10) ; mc11 = (ma10 * mb01) + (ma11*mb11);
            MatrixChecker.CheckMultiplication(ma00, ma01, ma10, ma11, mb00, mb01, mb10, mb11, mc00, mc01, mc10, mc11);
            Draw2x2Matrix(mc00, mc01, mc10, mc11);

            Console.WriteLine("");

            //Här

            float a1, a2, a3, a4; //matris A    
            float b1, b2, b3, b4; //matris B
            float ab1, ab2, ab3, ab4; //produkten av A och B

            Console.WriteLine("skriv fyra nummer");
            string usera1 = Console.ReadLine();
            Console.WriteLine("");
            string usera2 = Console.ReadLine();
            Console.WriteLine("");
            string usera3 = Console.ReadLine();
            Console.WriteLine("");
            string usera4 = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Skriv fyra nummer till");
            Console.WriteLine("");
            string userb1 = Console.ReadLine();
            Console.WriteLine("");
            string userb2 = Console.ReadLine();
            Console.WriteLine("");
            string userb3 = Console.ReadLine();
            Console.WriteLine("");
            string userb4 = Console.ReadLine();
            Console.WriteLine("");

            float.TryParse(usera1, out a1);
            float.TryParse(usera2, out a2);
            float.TryParse(usera3, out a3);
            float.TryParse(usera4, out a4);
            float.TryParse(userb1, out b1);
            float.TryParse(userb2, out b2);
            float.TryParse(userb3, out b3);
            float.TryParse(userb4, out b4);

            float ab = ab1 = (a1 * b1) + (a2 * b3); ab2 = (a1 * b2) + (a2 * b4); ab3 = (a3 * b1) + (a4 * b3); ab4 = (a3 * b2) + (a4 * b4);
            Draw2x2Matrix(ab1, ab2, ab3, ab4);

            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            
            Console.WriteLine("Du skrev dom här numren");
            Draw2x2Matrix(a1, a2, a3, a4);
            Console.WriteLine("");
            Console.WriteLine("Du multiplicerade den med");
            Draw2x2Matrix(b1, b2, b3, b4);


            Console.ReadKey();
        }
    }
}
