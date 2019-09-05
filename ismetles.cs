using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ismetles
{
  class Program
  {
    static void Main(string[] args)
    {
      // Képernyőre írás
      Console.WriteLine(); // teljes sor, kurzor az új sorban
      Console.Write("hello"); // megadott paramétrenek megfelelő
      // \n -> új sort jelent
      Console.WriteLine("\n{0} ez meg ez {1}","Az","az"); // paraméterezett

      // változók bevezetése
      // típus név [kezdőérték]
      // int float double char string bool
      int a = 3;
      int b;

      b = 10;
      Console.WriteLine("{0} + {1} = {2}",a ,b ,a+b);

      char ch = 'a'; // egyes idézőjel
      string szo = "több is lehet"; // kettős idézőjel

      Console.WriteLine("Karakter: {0}, szo:{1}",ch, szo);

      float pi = 3.14f;

      // pi = b / a;
      pi = (float)b / a;
      Console.WriteLine(pi);

      // maradékos osztás
      int maradek = b % a;
      Console.WriteLine("Maradék: {0}",maradek);

      // logikai változó
      bool igaz = true; // true, false

      // számokkal végezhető műveletek
      // +, -, *, /, % (maradék képzés)

      // string-el végezhető műveletek
      // "alma" + " fa" = "alma fa" -> konkatenálás, összefűzés
      string fa = "alma" + " fa";
      Console.WriteLine(fa);

      // elágazások 
      if (igaz) // ha a kifejezés igaz
      {
        Console.WriteLine("Jééé igaz!");
      }

      igaz = false;

      if (igaz)
      {
        Console.WriteLine("Jééé igaz!");
      }
      else 
      {
        Console.WriteLine("Mégsem igaz!");
      }

      // sok elágazás
      if (a == 1)
      {
        Console.WriteLine("\"a\" értéke 1");
      }
      else if (a == 2)
      {
        Console.WriteLine("\"a\" értéke 2");
      }
      else if (a == 3)
      {
        Console.WriteLine("\"a\" értéke 3");
      }
      else
      {
        Console.WriteLine("\"a\" értéke nem 1, 2 és 3...");
      }

      switch (a)
      {
        case 1:
          Console.WriteLine("Ez egy");
          break;
        case 2:
          Console.WriteLine("Ez kettő");
          break;
        case 3:
          Console.WriteLine("Ez három");
          break;
        default:
          Console.WriteLine("Nem egy, kettő vagy három!");
          break;
      }

      // ciklusok for, while, do...while
      // ismételt feladatok végrehajtása

      for (int i = 0; i < 10; i++) // [0..9]
      {
        Console.WriteLine(i);
      }

      // visszafelé
      for (int i = 10; i > 0; i--) // [10..1]
      {
        Console.WriteLine(i);
      }

      Console.WriteLine("Ez most \"while\"");
      int j = 0;

      // elöltesztelős
      while (j < 10) // amíg j kisebb mint 10, amíg igaz
      {
        Console.WriteLine(j);
        j++;
      }

      // hátultesztelős 
      do
      {
        Console.WriteLine(j);
        j++;
      } while (j < 10);


      Console.ReadKey(); // egy billentyű lenyomására vár
    }
  }
}
