using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

           

         

        }


        public void Show(string ss)
        {
            if (this.InvokeRequired)
            {
                Action<string> messageTarget =  (_ss) =>
                {
                    this.Text = _ss;
                };

                this.Invoke(messageTarget, ss);
            }
            else {
                this.Text = ss;
                   }
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {

                while (true)
                {

                    Show(DateTime.Now.ToString("HH:mm:ss"));

                    Thread.Sleep(1000);
                }

            });
          

            
        }


    }
}
