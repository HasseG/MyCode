using System.Threading;
using System;
using System.Threading.Tasks.Dataflow;

namespace ThreadSafety
{
    internal class Program
    {
        static int mainSum = 0;
        static int checkSum = 0;
        static Object myLock = new Object();
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                //Start threads an execute the method
                Thread thread1 = new Thread(DoWork);
                thread1.Name = "Thread 1";
                thread1.Start();

                Thread thread2 = new Thread(DoWork);
                thread2.Name = "Thread 2";
                thread2.Start();

                Thread thread3 = new Thread(DoWork);
                thread3.Name = "Thread 3";
                thread3.Start();

                //Wait for alle threads to finish
                thread1.Join();
                thread2.Join();
                thread3.Join();

                Console.WriteLine($"Main Thread - {mainSum}");
                Console.WriteLine($"Check sum - {checkSum}");
            }
            Console.ReadKey();
        }

        static void DoWork()
        {
            int mySum = 0;
            Random random = new Random();

            for (int i = 0; i < 300; i++)
            {
                Thread.Sleep(5);

                int randomValue = random.Next(0, 10);
                mySum += randomValue;

                lock (myLock)
                {
                    mainSum += randomValue;
                    checkSum += randomValue;
                }

            }

            Console.WriteLine($"{Thread.CurrentThread.Name} - {mySum}");
        }
    }
}