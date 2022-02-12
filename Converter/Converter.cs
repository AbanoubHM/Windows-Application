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
using AdvCDay5;

namespace Converter {
    public partial class Converter : Form {
        ConverterType converter=ConverterType.MtoKM;
        public Converter() {
            InitializeComponent();
        }
        private void ConverterChkbox(object sender, EventArgs e) {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked) {
                converter = (ConverterType)Enum.Parse(typeof(ConverterType), radio.Name);
            }
        }

        private async void ConvertBtn_Click(object sender, EventArgs e) {

            Task<string> task = new Task<string>(returnConverted);
            task.Start();
            ResultTxtBox.Text = await task;
            
            }

        private string returnConverted() {
            //Thread.Sleep(5000);
            switch (converter) {
                case ConverterType.MtoKM:
                    return String.Format("" + ValueNum.Value / 1000);

                case ConverterType.MtoMi:
                    return String.Format("" + ValueNum.Value / (decimal)1609.34);

                case ConverterType.MitoM:
                    return String.Format("" + ValueNum.Value * (decimal)1609.34);

                default:
                    return "ERROR!!";

            }
        }
    }
    enum ConverterType {
        MtoKM,
        MtoMi,
        MitoM
    }
}
