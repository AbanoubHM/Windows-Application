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
    public partial class FormatPicker : Form {
        FontC ff;
        bool colflag = false;
        
        public FormatPicker(FontC font) {
            InitializeComponent();
            ff= font;
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked) {
                switch (radio.Text) {
                    case "Red":
                        ff.color= Color.Red;
                        break;
                    case "Green":
                        ff.color = Color.Green;
                        break;
                    case "Blue":
                        ff.color=Color.Blue;
                        break;
                    default:
                        ff.color = Color.Black;
                        break;
                }
                colflag = true;
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) {
            CheckBox c = sender as CheckBox;
            if (c.Checked) {
                ff.f |= (FontStyle)Enum.Parse(typeof(FontStyle), c.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if (!colflag) { ff.color = Color.Red; }
            if (comboBox1.SelectedIndex == -1) {
                MessageBox.Show("Select Font");
            } else {
                ff.font = comboBox1.Text;
                ff.size = (int)numericUpDown1.Value;
                this.Close();
            }
        }
    }
}
