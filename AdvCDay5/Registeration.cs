using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AdvCDay5 {
    public partial class Registeration : Form {
        Gender g;
        Hoppy h;
        bool errName = true;
        bool errMail = true;
        bool errChkBox = true;
        public Registeration() {
            InitializeComponent();
            //RegisterBtn.Hide();
            NameErrorLbl.Hide();
            EmailErrorLbl.Hide();
            HoppiesErrorLbl.Hide();
            DoneTxt.Hide();
        }



        bool IsValidEmail(string email) {
            try {
                var mail = new System.Net.Mail.MailAddress(email);
                return true;
            } catch {
                //MessageBox.Show(e.Message);
                return false;
            }

        }
        bool IsValidName(string name) {
            if (NameTxt.Text.Length < 5)
                return false;
            return true;
        }





        private void RegisterBtn_Click(object sender, EventArgs e) {
            if (!errMail && !errName && !errChkBox) {
                Person person = new Person();
                person.Name = NameTxt.Text;
                person.Email = EmailTxt.Text;
                person.gender = g;
                person.hoppy = h;
                DoneTxt.Text = "Regiseration Complete";
                DoneTxt.ForeColor = System.Drawing.Color.Green;

                DoneTxt.Show();
            } else {
                DoneTxt.Text = "Incomplete Form";
                DoneTxt.ForeColor = System.Drawing.Color.Red;
                DoneTxt.Show();
            }


        }



        private void MaleRadio_CheckedChanged(object sender, EventArgs e) {
            RadioButton radio = sender as RadioButton;
            if (radio.Checked) {
                g = (Gender)Enum.Parse(typeof(Gender), radio.Text);
            }
        }

        private void FootballChkBox_CheckedChanged(object sender, EventArgs e) {
            CheckBox c = sender as CheckBox;
            if (c.Checked) {
                h |= (Hoppy)Enum.Parse(typeof(Hoppy), c.Text);
            }
        }



        private void NameTxt_TextChanged(object sender, EventArgs e) {
            if (!IsValidName(NameTxt.Text)) {
                MessageBox.Show("Wrong Name Format");
            }
        }

        private void ChkBox_Validating(object sender, EventArgs e) {
            bool chkd = false;
            foreach (var item in this.Controls) {
                if (item is CheckBox) {
                    if (((CheckBox)item).Checked) {
                        chkd = true;
                        //RegisterBtn.Show();

                    }
                }

            }
            if (!chkd) {
                //e.Cancel = true;
                HoppiesErrorLbl.Text = "You Must select at least 1";
                HoppiesErrorLbl.Show();
                errChkBox=true;
            } else {
                HoppiesErrorLbl.Hide();
                errChkBox=false;
            }
        }
        //private void ChkBox_Validated(object sender, System.EventArgs e) {
        //    // If all conditions have been met, clear the ErrorProvider of errors.
            
        //}

        private void NameTxt_Validating(object sender,
                System.ComponentModel.CancelEventArgs e) {

            if (!IsValidName(NameTxt.Text)) {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                //NameTxt.Select(0, NameTxt.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                //this.errorProvider1.SetError(NameTxt, "Wrong Name Format");
                NameErrorLbl.Text = "Wrong Name Format";
                NameErrorLbl.Show();
                errName = true;
            }

        }
        private void NameTxt_Validated(object sender, System.EventArgs e) {
            // If all conditions have been met, clear the ErrorProvider of errors.
            //errorProvider1.SetError(NameTxt, "");
            NameErrorLbl.Hide();
            errName=false;
        }




        private void EmailTxt_Validating(object sender,
                System.ComponentModel.CancelEventArgs e) {
            string errorMsg;
            if (!ValidEmailAddress(EmailTxt.Text, out errorMsg)) {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                EmailTxt.Select(0, EmailTxt.Text.Length);
                errMail = true;
                // Set the ErrorProvider error with the text to display. 
                //errorProvider1.SetError(EmailTxt, errorMsg);
                EmailErrorLbl.Text = "Wrong Email Format";
                EmailErrorLbl.Show();
            }

        }

        private void EmailTxt_Validated(object sender, System.EventArgs e) {
            // If all conditions have been met, clear the ErrorProvider of errors.
            //errorProvider1.Clear();
            EmailErrorLbl.Hide();
            errMail=false;
        }
        public bool ValidEmailAddress(string emailAddress, out string errorMessage) {
            if (!IsValidEmail(emailAddress)) {
                errorMessage = "email address must be valid email address format.\n" +
                               "For example 'someone@example.com' ";
                return false;
            }


            errorMessage = "";
            return true;


        }

        
    }

    
}
