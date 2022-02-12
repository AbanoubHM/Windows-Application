using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Format {
    public partial class Progress : Form {
        public Progress() {
            InitializeComponent();
            timer1.Start();
        }

        private void trackBar1_Scroll(object sender, EventArgs e) {

            timer1.Interval = 1000/trackBar1.Value;
        }

        private void timer1_Tick(object sender, EventArgs e) {
            if (progressBar1.Value < 100) {
                progressBar1.Value++;
            } else {
                progressBar1.Value = 0;
            }
        }
    }
}
