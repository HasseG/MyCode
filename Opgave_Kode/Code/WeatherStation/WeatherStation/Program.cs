﻿namespace WeatherStation
{
    internal class Program
    {
        private double accum = 0.0;
        private const int WEATHERSTATIONS = 100;
        private const int MEASURES = 1000;
        private const double VALUE = 1.0;
        static object locker = new object();

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Run();
        }

        private void Run()
        {
            const double EXPECTED = WEATHERSTATIONS * MEASURES * VALUE;
            for (int i = 0; i < 10; i++)
            {
                accum = 0.0;
                double result = Measure();
                if (result != EXPECTED)
                {
                    Console.WriteLine("ERROR: " + (EXPECTED - result));
                }
            }
            Console.Write("Press a key ..."); Console.ReadKey();
        }

        private double Measure()
        {
            Thread[] threads = new Thread[WEATHERSTATIONS];
            for (int i = 0; i < WEATHERSTATIONS; i++)
            {
                threads[i] = new Thread(Sensor);
                threads[i].Start();
            }
            //Do not join until all threads are started
            for (int i = 0; i < WEATHERSTATIONS; i++)
            {
                threads[i].Join();
            }
            return accum;
        }

        private void Sensor()
        {
            Monitor.Enter(locker);
            try
            {
                for (int i = 0; i < MEASURES; i++)
                {
                    double temp = accum;
                    //do some work 
                    //Thread.Sleep(1);
                    accum = temp + VALUE;
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally { Monitor.Exit(locker); }
        
        }

    }
}