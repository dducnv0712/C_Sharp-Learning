using System;
using System.Threading;
namespace Lab.lab5
{
   
        internal class Program
        {
            public static void Main(string[] args)
            {
                Console.WriteLine("Set Min");
                int min = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.WriteLine("Set Sec");
                int sec = int.Parse(Console.ReadLine() ?? string.Empty);
                for (; min < 60; )
                {
                    for (; sec < 60; sec--)
                    {
                        Console.WriteLine(min + " : " + sec);
                        try
                        {
                            Thread.Sleep(100);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            throw;
                        }

                        if (sec <0)
                        {
                            sec = 59;
                        }

                        min--;
                    }
                }
                Console.Write("Bummmm...");
                /*while (min>=0){
                    while (sec>=0){
                        Console.WriteLine(min + " : " + sec);
                        sec--;
                        try {
                            Thread.Sleep(100);
                        }catch (Exception e){
                           
                        }
                    }
                    if(sec <0){
                        sec=59;
                    }
                    min--;
                 
                }  */
                Console.Write("Bummmm..");
            }
        }

       
    }
