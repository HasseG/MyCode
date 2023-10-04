namespace FilosoffernesBord
{
    internal class Program
    {
        static object myLock1 = new object();
        static object myLock2 = new object();
        static object myLock3 = new object();
        static object myLock4 = new object();
        static object myLock5 = new object();
        static object myLock6 = new object();
        static Thread F1;
        static Thread F2;
        static Thread F3;
        static Thread F4;
        static Thread F5;

        static Chopstick C1;
        static Chopstick C2;
        static Chopstick C3;
        static Chopstick C4;
        static Chopstick C5;
        static void Main(string[] args)
        {
            C1 = new Chopstick("C1");
            C2 = new Chopstick("C2");
            C3 = new Chopstick("C3");
            C4 = new Chopstick("C4");
            C5 = new Chopstick("C5");

            F1 = new Thread(StartPhilosopher);
            F1.Name = "F1";

            F2 = new Thread(StartPhilosopher);
            F2.Name = "F2";

            F3 = new Thread(StartPhilosopher);
            F3.Name = "F3";

            F4 = new Thread(StartPhilosopher);
            F4.Name = "F4";

            F5 = new Thread(StartPhilosopher);
            F5.Name = "F5";

            F1.Start();
            F2.Start();
            F3.Start();
            F4.Start();
            F5.Start();
        }

        static void StartPhilosopher()
        {
            bool active = true;
            while (active)
            {
                bool noChipstick = true;
                while (noChipstick)
                {
                    Thread.Sleep(1000);
                    if (Thread.CurrentThread.Name == F1.Name)
                    {
                        if(Monitor.TryEnter(C1.IsLocked) && Monitor.TryEnter(C2.IsLocked))
                        {
                            Eat(C1, C2);
                            Sleep();
                            Monitor.Pulse(C1);
                            Monitor.Pulse(C2);
                            Monitor.Exit(C1);
                            Monitor.Exit(C2);
                            noChipstick = false;
                        }
                    }
                    Thread.Sleep(1000);
                    if (Thread.CurrentThread.Name == F2.Name)
                    {
                        if (Monitor.TryEnter(C2.IsLocked) && Monitor.TryEnter(C3.IsLocked))
                        {
                            Eat(C2, C3);
                            Sleep();
                            Monitor.Pulse(C2);
                            Monitor.Pulse(C3);
                            Monitor.Exit(C2);
                            Monitor.Exit(C3);
                            noChipstick = false;
                        }
                    }
                    Thread.Sleep(1000);
                    if (Thread.CurrentThread.Name == F3.Name)
                    {
                        if (Monitor.TryEnter(C3.IsLocked) && Monitor.TryEnter(C4.IsLocked))
                        {
                            Eat(C3, C4);
                            Sleep();
                            Monitor.Pulse(C3);
                            Monitor.Pulse(C4);
                            Monitor.Exit(C3);
                            Monitor.Exit(C4);
                            noChipstick = false;
                        }
                    }
                    Thread.Sleep(1000);
                    if (Thread.CurrentThread.Name == F4.Name)
                    {
                        if (Monitor.TryEnter(C4.IsLocked) && Monitor.TryEnter(C5.IsLocked))
                        {
                            Eat(C4, C5);
                            Sleep();
                            Monitor.Pulse(C4);
                            Monitor.Pulse(C5);
                            Monitor.Exit(C4);
                            Monitor.Exit(C5);
                            noChipstick = false;
                        }
                    }
                    Thread.Sleep(1000);
                    if (Thread.CurrentThread.Name == F5.Name)
                    {
                        if (Monitor.TryEnter(C5.IsLocked) && Monitor.TryEnter(C1.IsLocked))
                        {
                            Eat(C1, C5);
                            Sleep();
                            Monitor.Pulse(C1);
                            Monitor.Pulse(C5);
                            Monitor.Exit(C1);
                            Monitor.Exit(C5);
                            noChipstick = false;
                        }
                    }
                }
            }
        }

        static void Eat(Chopstick chopstick1, Chopstick chopstick2)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is now eating with {chopstick1.Name} and {chopstick2.Name}");
            Thread.Sleep(5000);
            Console.WriteLine($"{Thread.CurrentThread.Name} is done eating");
        }

        static void Sleep()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} is now sleeping");
            Thread.Sleep(10000);
            Console.WriteLine($"{Thread.CurrentThread.Name} is done sleeping");
        }

    }
}