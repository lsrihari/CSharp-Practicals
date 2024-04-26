using System.Diagnostics;
using System.Threading.Tasks.Sources;
using System.Xml.Serialization;

namespace CSharp.Practicals
{
    internal class Program
    {
        static Semaphore s1 = null;
        static AutoResetEvent objAuto =new AutoResetEvent(false);
        static ManualResetEvent objManual = new ManualResetEvent(false);
        static void Main(string[] args)
        {

            #region Thread - 1
            //Thread obj1 = new Thread(Function1); // -> Foreground threads
            ////Thread obj2 = new Thread(Function2);
            ////obj1.IsBackground = true; // setting as background thread
            //obj1.Start();
            ////obj2.Start();
            //Console.WriteLine("Main program exited");
            #endregion
            #region Mutex
            //using (var m1 = new Mutex(false, "CSharp.Practicals"))
            //{
            //    if (!m1.WaitOne(5000, false))
            //    {
            //        Console.WriteLine("Instance running already.");
            //        Console.ReadLine();
            //        return;
            //    }
            //    Console.WriteLine("App running...");
            //    Console.ReadLine();
            //}
            #endregion
            #region Semaphore
            //try
            //{
            //    s1 = Semaphore.OpenExisting("CSharp.Practicals");
            //}
            //catch
            //{
            //    s1 = new Semaphore(1, 2, "CSharp.Practicals");
            //}
            //Console.WriteLine("Acquiring");
            //s1.WaitOne();
            //Console.WriteLine("Thread acquired");
            //Console.ReadLine();
            //s1.Release();
            #endregion
            #region Auto/Manual Reset Event
            #region Auto Event
            //new Thread(SomeMethod).Start();// it will invoke someMethod in a diffrent thread.
            //Console.ReadLine();
            ////signaled to start again
            //objAuto.Set();//waitone at 1
            //Console.ReadLine();
            ////signaled to start again
            //objAuto.Set();//waitone at 2
            #endregion
            #region Manual Event
            //new Thread(SomeMethod).Start();// it will invoke someMethod in a diffrent thread.
            //Console.ReadLine();
            ////signaled to start again
            //objManual.Set();//waitone is enough to run all the threads
            #endregion


            #endregion
            #region Thread Pooling
            //Console.WriteLine("Starting warmup...");
            //for(int i = 0; i < 10; i++)
            //{
            //    WithThreadPool();
            //    WithThreadPool();
            //}
            //Console.WriteLine("Stopping warmup...");
            //Stopwatch stWatch = new Stopwatch();

            //Console.WriteLine("Recording with Thread pool");
            //stWatch.Start();
            //WithThreadPool();
            //stWatch.Stop();
            //Console.WriteLine(stWatch.ElapsedTicks.ToString());
            //stWatch.Reset(); 

            //Console.WriteLine("Recording without Thread pool");
            //stWatch.Start();
            //WithoutThreadPool();
            //stWatch.Stop();
            //Console.WriteLine(stWatch.ElapsedTicks.ToString());
            //stWatch.Reset();
            //Console.ReadLine();
            #endregion
            #region TPL
            //Parallel.For(0, 1000000, x => RunMillionIteration());
            //Console.ReadLine();
            //for(int i=0;i<1000;i++)
            //{
            //    //Thread o = new Thread(new ThreadStart(TPLFucntion));
            //    //o.Start();
            //    Task o=new Task(TPLFucntion);
            //    o.Start();
            //}
            //Console.ReadLine();
            #endregion

            #region Inheritance
            Inheritance inObj = new Inheritance();
            #endregion
        }



        static void Function1()
        { 
            for(int i=0;i<10;i++){
                Console.WriteLine("I am function 1 iteration - "+i);
                Console.ReadLine();
                //Thread.Sleep(2000);
                Console.WriteLine("Exiting function 1.");
            }
        }
        static void Function2()
        {
            for (int i = 0; i < 10; i++) {
                Console.WriteLine("I am function 2 iteration-"+i);
                Thread.Sleep(2000);
            }
        }

        static void SomeMethod()
        {
            #region Auto
            //Console.WriteLine("Starting 1...");
            ////wait1
            //Console.WriteLine("Waiting 1...");
            //objAuto.WaitOne();
            //Console.WriteLine("Finishing 1...");
            //Console.WriteLine("Starting 2...");
            ////wait2
            //Console.WriteLine("Waiting 2...");
            //objAuto.WaitOne();
            //Console.WriteLine("Finishing 2...");
            #endregion

            #region Manual
            //Console.WriteLine("Starting 1...");
            ////wait1
            //Console.WriteLine("Waiting 1...");
            //objManual.WaitOne();
            //Console.WriteLine("Finishing 1...");
            //Console.WriteLine("Starting 2...");
            ////wait2
            //Console.WriteLine("Waiting 2...");
            //Console.WriteLine("Finishing 2...");
            #endregion


        }

        static void ThreadPoolFunction(object o)
        {
            //Console.WriteLine("Thread pool func() called.");
        }
        static void WithThreadPool()
        {
            for(int i  = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadPoolFunction));
            }
        }

        static void WithoutThreadPool()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread t1= new Thread(ThreadPoolFunction);
                t1.Start(); 
            }
        }

        private static void RunMillionIteration()
        {
            string x = "";
            for (int i = 0; i < 1000000; i++)
            {
                x = x + "s";
            }
        }

        private static void TPLFucntion()
        {
            string x = "";
            x = "Srihari";
        }
    }
}
