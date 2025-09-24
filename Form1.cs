using System;
using System.Threading;
using System.Windows.Forms;

namespace BasicThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void StartThread_Click(object sender, EventArgs e)
        {
            Thread background = new Thread(RunThreads);
            background.IsBackground = true;
            background.Start();
        }

        private void RunThreads()
        {
            Thread ThreadA = new Thread(MyThreadClass.Thread1);
            Thread ThreadB = new Thread(MyThreadClass.Thread1);

            ThreadA.Name = "ThreadA";
            ThreadB.Name = "ThreadB";

            ThreadA.Start();
            ThreadB.Start();

            ThreadA.Join();
            ThreadB.Join();


            this.Invoke((MethodInvoker)delegate
            {
                Threading.Text = "- End Of Thread -";
            });
        }
    }


    public class MyThreadClass
    {
        public static void Thread1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Thread thread = Thread.CurrentThread;
                Console.WriteLine("Name of Thread: " + thread.Name + " = " + i);
                Thread.Sleep(1500);
            }
        }
    }
}
