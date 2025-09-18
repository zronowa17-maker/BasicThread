using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
namespace BasicThread
{
    public partial class FrmBasicThread : Form
    {
        public FrmBasicThread()
        {
            InitializeComponent();
            this.Text = "Basic Threading";
            label1.Text = "-Before starting thread-";
        }

        private void bntRun_Click(object sender, EventArgs e)
        {
            Console.WriteLine("-Before starting thread-");

            Thread threadA= new Thread(MyThreadClass.Thread1);
            Thread threadB = new Thread(MyThreadClass.Thread1);

            threadA.Name = "Thread A Process";
            threadB.Name = "Thread B Process";

            threadA.Start();
            threadB.Start();

            threadA.Join();
            threadB.Join();

            label1.Text = "-End of Thread-";
            Console.WriteLine("The thread 0x" + threadA.ManagedThreadId.ToString("X") + " has excited with code 0 (0x0)");
            Console.WriteLine("The thread 0x" + threadB.ManagedThreadId.ToString("X") + " has excited with code 0 (0x0)");

           
            Console.WriteLine("-End of Thread-");
        }
    }
}
