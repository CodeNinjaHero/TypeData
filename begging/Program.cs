
using System.Text;

namespace begging 
{
    public class Begging
    {
        public static void Main(string[] arr)
        {
           
            int num = 10;
            float f = 14.2f;
            char ch = 'a';
            decimal de = 0;
            long lg = 0;
            string str = "dsadas";
            StringBuilder strBul = new StringBuilder("hola");

            int num2, num3, num4;

            var variable = 'd';
            
            // dinamic obj var 

            //Console.WriteLine(str);

            int[] arrayInt = { 1, 2, 3 };
            arrayInt.Append(0);

            for (int i=0; i<10; i++)
            {
              //  Console.WriteLine(i);
            }

            foreach (var i in arrayInt)
            {
                //Console.WriteLine(i);
            }
            /*
            bool flag = true;
            while(flag)
            {
                var count = 0;
                if(count > 5)
                {
                    flag = false;
                }
                count++;
            }*/
               
            // do - while
        
            List<int> lst = new List<int>();
            lst.Add(1);


            var beer = new Beer("Corona", "nose");
            List<Beer> beers = new List<Beer>()
            {
                new Beer("Corona", "nose"),
                new Beer("La mal portada", "nose"),
                new Beer("Ron del caldas", "nose")
            };

            foreach(var b in beers)
            {
                Console.WriteLine(b);
            }


            var calculator = new Calculator(15);
            calculator.Factorial(5);


        }
    
    
    
    }
}