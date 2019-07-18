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


namespace Parcel_Log
{
     public partial class addEntry : Form
    {
        public addEntry()
        {
            InitializeComponent();
        }
        private Boolean controlsValidation() {
            foreach (Control c in this.Controls)
            {
                if (c.Text == "" && c.Name != "tbNotes")
                {
                    MessageBox.Show("A Required field (*) is empty.");
                    return false;
                }
            }
            return true;
        }

        private void updateFile()
        {
            Parcel p = new Parcel();
            p.date = DateTime.Now+"";
            p.name = tbLname.Text.ToUpper() +", " + tbFname.Text.ToUpper();
            p.notes = tbNotes.Text;
            p.qnt = Convert.ToInt32(tbQnt.Text);
            p.staffInitials = tbStaffInitials.Text;
            p.suite = tbSuite.Text;
            p.email = tbEmail.Text;
            p.building = cbBuilding.Text;
            p.box = p.calculateBox(tbFname.Text.Substring(0,1));



            StreamWriter writer = new FileInfo("InfoList.txt").AppendText();

            writer.WriteLine(p.createFileLine());


            writer.Close();
        }



        private void addEntry_Load(object sender, EventArgs e)
        {
            cbBuilding.Items.Add("TRA1");
            cbBuilding.Items.Add("TRA2");
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (controlsValidation())
            {
                if (!doesEntryExists(tbFname.Text.ToUpper(), tbLname.Text.ToUpper()))
                { 
                    updateFile();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Entry already exists", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private Boolean doesEntryExists(string fname, string lname)
        {
            int index;
            string name = lname +", " +fname;
            Boolean exists = false;

            for (index = 0; index < parcelLog.globals.building.Length; index++)
            {
                if (parcelLog.globals.building[index] != null)
                {
                    if (parcelLog.globals.building[index].name.Equals(name)) {
                         exists = true;
                    }
                }
            }
            return exists;            
        }
    }
}
