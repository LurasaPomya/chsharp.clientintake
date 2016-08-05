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

        const string FileName = @"..\..\SavedClient.bin";
        private Client client = new Client();
        public IntakeForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (saveForm())
            {
                popupMsg("Saved!");
            }
        }

        private void popupMsg(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }

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

            Stream fs = File.Create(FileName);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(fs, client);
            fs.Close();

            return true;
        }

        private bool loadForm()
        {
            if (File.Exists(FileName))
            {

                client.FirstName = "Steve";
                popupMsg(client.FirstName);

                Stream fs = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                client = (Client)deserializer.Deserialize(fs);
                fs.Close();

                popupMsg(client.FirstName);
            }


            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadForm();
        }
    }
}
