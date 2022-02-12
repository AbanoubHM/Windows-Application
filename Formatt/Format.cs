using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formatt {
    public partial class Landing : Form {
        FormatPicker fp;
        FontC ff=new FontC();
        public Landing() {
            InitializeComponent();
        }

        private void FormatBtn_Click(object sender, EventArgs e) {
            if (String.IsNullOrEmpty(textBox1.Text)) {
                MessageBox.Show("Enter Text");
            } else {
                textBox1.Font = new Font(ff.font, ff.size, FontStyle.Regular);
                fp = new FormatPicker(ff);
                fp.ShowDialog();
                textBox1.ForeColor = ff.color;
                textBox1.Font = new Font(ff.font, ff.size, ff.f);
            }

        }
    }
}
