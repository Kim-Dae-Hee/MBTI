using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Filtering.Templates;

namespace MBTI.Forms
{
    public partial class TestForm : DevExpress.XtraEditors.XtraForm
    {

        Timer t = new Timer();
        public TestForm()
        {
            InitializeComponent();
            //timer1.Start();
        }

        int duration = 0;

        private void TestForm_Load(object sender, EventArgs e)
        {

            t.Tick += new EventHandler(this.t_Tick);

            t.Start();

        }
        
        
        
        private void t_Tick(object sender, EventArgs e)
        {
            
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
                time += hh;
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
                time += mm;
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
                time += ss;

            label3.Text = time;
            
            /*
            duration++;

            label3.Text = duration.ToString();

            if (duration == 10)
            {
                timer1.Stop();
            }
            */
        }
        
    }
}