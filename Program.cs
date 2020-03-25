using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPPOON
{
    class Program
    {
        static void Main(string[] args)
        {
            Note FirstNote = new Note();
            Note SecondNote = new Note("Domagoj", "Vani pada snijeg!");
            Note ThirdNote = new Note("Marko", "Update: jos uvijek pada snijeg!", 1);
            TimeNote FirstTimeNote = new TimeNote();
            Console.WriteLine(FirstNote.ToString());
            Console.WriteLine(SecondNote.ToString());
            Console.WriteLine(ThirdNote.ToString());
            Console.WriteLine(FirstTimeNote.ToString());
        }
    }
 
}
