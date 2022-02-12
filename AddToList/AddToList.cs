using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvCDay5;

namespace AddToList {
    public partial class AddToList : Form {

        BindingList<Person> gridData = new BindingList<Person>();
        int rowIndex = 0;

        public AddToList() {
            InitializeComponent();
            dataGridView1.DataSource = gridData;
            
        }

        private void AddBtn_Click(object sender, EventArgs e) {
            gridData.Add(new Person { Name = NameTextBox.Text, Phone =int.Parse(PhoneTextBox.Text),BirthDate=dateTimePicker1.Value });
                
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) {
            rowIndex = e.RowIndex;
            NameTextBox.Text = gridData[rowIndex].Name;
            PhoneTextBox.Text = gridData[rowIndex].Phone.ToString();
            dateTimePicker1.Value = gridData[rowIndex].BirthDate;
        }

        private void SaveBtn_Click(object sender, EventArgs e) {
            gridData[rowIndex].Name = NameTextBox.Text;
            gridData[rowIndex].Phone = int.Parse(PhoneTextBox.Text);
            gridData[rowIndex].BirthDate = dateTimePicker1.Value;
            dataGridView1.Invalidate();
        }
    }
}
