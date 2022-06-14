using System;
using System.Collections;

namespace Arraylist
{
    public class Dept
    {
        public string Name{ get; set;}
        public int ID {get; set;}

        public string Location {get; set;}
    }
    class program
    {
        static void Main(string[] args)
        {

    // Dept Program using List
           /* list<Dept> list1 = new list<Dept>();
            Dept d1 = new Dept {Name ="Admin" ,ID=1,Location="Pune"};

            Dept d2 = new Dept {Name ="HR" ,ID=2,Location="Mumbai"};

            Dept d3 = new Dept {Name ="Sales" ,ID=3,Location="Hydrabad"};

            list1.Add(d1);
            list1.Add(d2);
            list1.Insert(1, d3);
            foreach(Dept d in list1)
            {
                System.Console.WriteLine($"{d.Name} {d.ID}{d.Location}");
            }*/

           /* Hashtable ht = new Hashtable();
            ht.Add("USA", "63");
            ht.Add("INDIA", "91");
            ht.Add("UK", "1");
            // ht.Add("White", "F0F0F0");
            // ht.Add("Black", "FFFFF");
            // ht.Add("Yellow", "FCER34");

            //ht.Remove("Black");

            foreach (DictionaryEntry d in ht)
            {
                System.Console.WriteLine($"{d.Key} - {d.Value}");
            }*/


          Stack stack = new Stack();
            stack.Push(20);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50);

            stack.Pop();
            stack.Pop();
            foreach(Object item in stack)
            {
                System.Console.WriteLine(item);
            }
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);

            queue.Dequeue();
            foreach (Object item in queue)
            {
                System.Console.WriteLine(item);
            }



        }
    }
}
