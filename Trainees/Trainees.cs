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

namespace Trainees {
    public partial class Trainees : Form {

        BindingList<Person> TraineeList = new BindingList<Person>();
        BindingList<Person> Lab1List = new BindingList<Person>();
        BindingList<Person> Lab2List = new BindingList<Person>();
        BindingList<Person> Lab3List = new BindingList<Person>();

        public Trainees() {
            InitializeComponent();
        }

        private void MovetoLab_Click(object sender, EventArgs e) {

            switch (LabComboBox.SelectedIndex) {
                case 0:

                    Lab1List.Add((Person)TraineeCheckListBox.SelectedItem);
                    break;
                case 1:
                    Lab2List.Add((Person)TraineeCheckListBox.SelectedItem);
                    break;
                case 2:
                    Lab3List.Add((Person)TraineeCheckListBox.SelectedItem);
                    break;
                default:
                    break;
            }
            TraineeList.Remove((Person)TraineeCheckListBox.SelectedItem);

        }

        private void Trainees_Load(object sender, EventArgs e) {
            TraineeList.Add(new Person() { Name = "Student1" });
            TraineeList.Add(new Person() { Name = "Student2" });
            TraineeList.Add(new Person() { Name = "Student3" });
            TraineeList.Add(new Person() { Name = "Student4" });
            TraineeList.Add(new Person() { Name = "Student5" });
            TraineeList.Add(new Person() { Name = "Student6" });
            Lab1List.Add(new Person() { Name = "Student7" });
            Lab1List.Add(new Person() { Name = "Student8" });
            Lab2List.Add(new Person() { Name = "Student9" });
            Lab2List.Add(new Person() { Name = "Student10" });
            Lab3List.Add(new Person() { Name = "Student11" });
            Lab3List.Add(new Person() { Name = "Student12" });
            var combo = new[] { "Lab 1", "Lab 2", "Lab 3" };

            LabComboBox.Items.AddRange(combo);

            TraineeCheckListBox.DataSource = TraineeList;
            TraineeCheckListBox.DisplayMember = "Name";
            //LabCheckListBox.DataSource = Lab1List;
            //LabCheckListBox.DisplayMember = "Name";
        }

        private void LabComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox combo = (ComboBox)sender;
            switch (combo.SelectedIndex) {
                case 0:
                    LabCheckListBox.DataSource = Lab1List;
                    break;
                case 1:
                    LabCheckListBox.DataSource = Lab2List;
                    break;
                case 2:
                    LabCheckListBox.DataSource = Lab3List;
                    break;
                default:
                    break;
            }
            LabCheckListBox.DisplayMember = "Name";

        }


        private void MoveAlltoLab_Click(object sender, EventArgs e) {
            switch (LabComboBox.SelectedIndex) {
                case 0:

                    foreach (var item in TraineeList) {
                        Lab1List.Add(item);
                    }
                    break;
                case 1:
                    foreach (var item in TraineeList) {
                        Lab2List.Add(item);
                    }
                    break;
                case 2:
                    foreach (var item in TraineeList) {
                        Lab3List.Add(item);
                    }
                    break;
                default:
                    break;
            }
            TraineeList.Clear();
        }

        private void MovetoTrainee_Click(object sender, EventArgs e) {

            TraineeList.Add((Person)LabCheckListBox.SelectedItem);
            switch (LabComboBox.SelectedIndex) {
                case 0:
                    Lab1List.Remove((Person)LabCheckListBox.SelectedItem);
                    break;
                case 1:
                    Lab2List.Remove((Person)LabCheckListBox.SelectedItem);
                    break;
                case 2:
                    Lab3List.Remove((Person)LabCheckListBox.SelectedItem);
                    break;
                default:
                    break;
            }
        }

        private void MoveAlltoTrainee_Click(object sender, EventArgs e) {
            switch (LabComboBox.SelectedIndex) {
                case 0:

                    foreach (var item in Lab1List) {
                        TraineeList.Add(item);
                    }
                    Lab1List.Clear();
                    break;
                case 1:
                    foreach (var item in Lab2List) {
                        TraineeList.Add(item);
                    }
                    Lab2List.Clear();
                    break;
                case 2:
                    foreach (var item in Lab3List) {
                        TraineeList.Add(item);
                    }
                    Lab3List.Clear();
                    break;
                default:
                    break;
            }

        }
    }
}