using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace UI_Processing
{
    public partial class frmloop : Form
    {
        public frmloop()
        {
            InitializeComponent();
        }
        int loopvalue;

    
       

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
              
                //start the background work asynchronously 
                backgroundWorker1.RunWorkerAsync();
            }
            catch(Exception)
            {
                throw new Exception("Something went wrong");
            }
           

        }
        private void btncatch_Click(object sender, EventArgs e)
        {

            try
            {
                //output the global variable holding the current loop value and the formatted current time
                rtxtouput.AppendText(loopvalue + " - " + String.Format("{0:dd MMMM yyyy HH:mm:ss}", DateTime.Now) + "\n");

            }
            catch(Exception)
            {
                throw new Exception("Something went wrong");
            }
           
            
        }

        private void startloop()
        {
            for (int i = 0; i < 1001; i++)
            {
                loopvalue = i;
                if (i == 1000)
                {
                    i = 0;
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (backgroundWorker1.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                //start the loop if no task cancelling pending
                startloop();
            }
        }

        private void frmloop_FormClosed(object sender, FormClosedEventArgs e)
        {
           
            //cancell the background work asynchronously
            backgroundWorker1.CancelAsync();
           
        }

    }
}
