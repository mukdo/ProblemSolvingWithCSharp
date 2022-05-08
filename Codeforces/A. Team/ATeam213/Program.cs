using System;

namespace ATeam231
{
    public class Program
    {
        static void Main(string[] args)
        {
            //this is first input line
            string number = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < Convert.ToInt32(number); i++)
            {
                string data = Console.ReadLine();
                string[] getValue = data.Split(' ');
                try
                {
                    int petya = Convert.ToInt32(getValue[0]);
                    int vasya = Convert.ToInt32(getValue[1]);
                    int tonya = Convert.ToInt32(getValue[2]);

                    int result = petya + vasya + tonya;

                    if(result > 1)
                    {
                        count++;
                    }

                }
                catch(Exception)
                {

                }
             
            }

            Console.WriteLine(count);
        }
    }
}
