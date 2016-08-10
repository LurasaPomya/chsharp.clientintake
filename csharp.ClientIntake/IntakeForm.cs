using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace csharp.ClientIntake
{
    public partial class IntakeForm : Form
    {

        string saveFileName = null;
        private Client client = new Client();

        public IntakeForm()
        {
            InitializeComponent();
        }

        private void popupMsg(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

        // TODO Implement audo save, ctrl + s save, and stop asking if we've already saved.
        private bool saveForm()
        {
            // Save Client Information
            client.FirstName = firstNameTxt.Text;
            client.LastName = lastNameTxt.Text;
            client.PreferredName = prefNameTxt.Text;
            client.SchoolName = schoolNameTxt.Text;
            client.SchoolGrade = gradeTxt.Text;
            client.Age = ageTxt.Text;
            client.PreferredGender = genderTxt.Text;
            client.Allergies = allergiesTxt.Text;

            // Save Parent Information
            client.ParentFirstName = parentFirstNameTxt.Text;
            client.ParentLastName = parentLastNameTxt.Text;
            client.ParentRelationship = parentRelationshipTxt.Text;
            client.ParentAddress1 = parentAddress1Txt.Text;
            client.ParentAddress2 = parentAddress2Txt.Text;
            client.ParentCity = ParentAddressCityTxt.Text;
            client.ParentState = parentAddressStateTxt.Text;
            client.ParentZipCode = parentAddressZipTxt.Text;
            client.ParentPrimaryPhone = parentPrimaryPhoneTxt.Text;
            client.ParentSecondaryPhone = parentSecondaryPhoneTxt.Text;
            client.ParentEmail = parentEmailTxt.Text;

            // Save Emergency Contact Information
            client.EmergencyName = emergFirstNameTxt.Text + " " + emergLastNameTxt.Text;
            client.EmergencyPhone = emergPhoneTxt.Text;
            client.EmergencyRelation = emergRelationshipTxt.Text;

            // Save Group Information
            client.GroupSST = groupSSTChk.Checked;
            client.GroupGW = groupGWChk.Checked;
            client.GroupKTH = groupKTChk.Checked;

            // Save Getting to Know You Stuff
            client.Hobbies = hobbiesRTB.Text;
            client.Goals = goalsRTB.Text;
            client.Helps = helpsRTB.Text;
            client.Challenges = challengesRTB.Text;
            client.AdditionalInformation = additionalRTB.Text;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Intake Form|*.dat";
            sfd.Title = "Save Client Form";
            if ((client.FirstName != "") && (client.LastName != ""))
            {
                sfd.FileName = client.LastName + "-" + client.FirstName + ".dat";
            }
            else
            {
                sfd.FileName = "client-form.dat";
            }

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                saveFileName = sfd.FileName;
                Stream fs = File.Create(sfd.FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(fs, client);
                fs.Close();

                return true;
            }
            else { return false; }
        }

        // TODO Implement "Are you Sure?" Popup
        private bool loadForm()
        {
            string loadFileName = saveFileName;

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "Intake Form|*.dat";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Stream fs = File.OpenRead(ofd.FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                client = (Client)deserializer.Deserialize(fs);
                fs.Close();

                // Load Client Information
                firstNameTxt.Text = client.FirstName;
                lastNameTxt.Text = client.LastName;
                prefNameTxt.Text = client.PreferredName;
                schoolNameTxt.Text = client.SchoolName;
                gradeTxt.Text = client.SchoolGrade;
                ageTxt.Text = client.Age;
                genderTxt.Text = client.PreferredGender;
                allergiesTxt.Text = client.Allergies;

                // Load Parent Information
                parentFirstNameTxt.Text = client.ParentFirstName;
                parentLastNameTxt.Text = client.ParentLastName;
                parentRelationshipTxt.Text = client.ParentRelationship;
                parentAddress1Txt.Text = client.ParentAddress1;
                parentAddress2Txt.Text = client.ParentAddress2;
                ParentAddressCityTxt.Text = client.ParentCity;
                parentAddressStateTxt.Text = client.ParentState;
                parentAddressZipTxt.Text = client.ParentZipCode;
                parentPrimaryPhoneTxt.Text = client.ParentPrimaryPhone;
                parentSecondaryPhoneTxt.Text = client.ParentSecondaryPhone;
                parentEmailTxt.Text = client.ParentEmail;

                // Load Emergency Contact Information
                string[] emergecyNameArray = client.EmergencyName.Split(' ');
                emergFirstNameTxt.Text = emergecyNameArray[0];
                emergLastNameTxt.Text = emergecyNameArray[1];

                emergPhoneTxt.Text = client.EmergencyPhone;
                emergRelationshipTxt.Text = client.EmergencyRelation;

                // Load Group Information
                groupSSTChk.Checked = client.GroupSST;
                groupGWChk.Checked = client.GroupGW;
                groupKTChk.Checked = client.GroupKTH;

                // Load Additional Information
                hobbiesRTB.Text = client.Hobbies;
                goalsRTB.Text = client.Goals;
                helpsRTB.Text = client.Helps;
                challengesRTB.Text = client.Challenges;
                additionalRTB.Text = client.AdditionalInformation;


                return true;
            }
            else { return false; }
        }

        //TODO Implement "Are you Sure?" Popup
        private void newForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).Clear();
                }

                if (c.HasChildren)
                {
                    newForm(c);
                }

                if (c is RichTextBox)
                {
                    ((RichTextBox)c).Clear();
                }

                if (c is CheckBox)
                {

                    ((CheckBox)c).Checked = false;
                }

                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            newForm(this);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveForm();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
