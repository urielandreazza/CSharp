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
using System.Net.Mail;

namespace Parcel_Log
{
    public partial class parcelLog : Form
    {
        //This is a way to simulate global variables, for the parcel log it made sense to make the array with all the
        //parcels available for the entire application.
        public class globals
        {
            public static Parcel[] building = new Parcel[999];
        }
        
        public parcelLog()
        {
            InitializeComponent();
        }


        //######################################################
        //################## Shared Methods ####################
        //######################################################
        private void setFilter(string filter)
        {
            loadArrays();
            parcelGrid.Rows.Clear();


            int index;

         

            for (index = 0; index < globals.building.Length; index++)
            {
                if (globals.building[index] != null) {

                    if (globals.building[index].building == filter || filter == "Both")
                    {

                        parcelGrid.Rows.Add(globals.building[index].date, globals.building[index].qnt,
                                            globals.building[index].name, globals.building[index].suite,
                                            globals.building[index].email, globals.building[index].box,
                                            globals.building[index].sent, globals.building[index].staffInitials,
                                            globals.building[index].building, globals.building[index].notes);
                    }
                 
                }
            }
          
        }

        private void loadArrays()
        {

            int i = 0;
            using (StreamReader reader = new StreamReader("InfoList.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split('|');
                    
                    
                    globals.building[i] = new Parcel();

                    globals.building[i].date = line[0];
                    globals.building[i].qnt = Convert.ToInt32(line[1]);
                    globals.building[i].name = line[2];
                    globals.building[i].suite = line[3];
                    globals.building[i].email = line[4];
                    globals.building[i].box = globals.building[i].calculateBox(globals.building[i].name.Substring(0,1).ToUpper());
                    globals.building[i].sent = Convert.ToBoolean(line[6]);
                    globals.building[i].staffInitials = line[7];
                    globals.building[i].building = line[8];
                    globals.building[i].notes = line[9];

                    i++;
                }
            }



        }

        //#####################################################################################
        //################################ EVENT HANDLERS #####################################
        //#####################################################################################

        //Load the DataSet when the Parcel Log is open
        private void parcelLog_Load(object sender, EventArgs e)
        {
            setFilter("Both");
        }


        private void rbt2_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt2.Checked) {
                setFilter(rbt2.Text);
            }
        }

        

        private void rbt1_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt1.Checked)
            {
                setFilter(rbt1.Text);
            }
        }
        //BOTH radio Button
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                setFilter(radioButton1.Text);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addEntry newTab = new addEntry();

            //Child Windowns From Subscribe to the Close event
            newTab.FormClosed += new FormClosedEventHandler(newTab_FormClosed);

            //Show the chield form
            newTab.Show();
            
        }
        private void newTab_FormClosed(object send, FormClosedEventArgs e)
        {
            //Update the parcelGrid
            updatePracelGrid();
        }

        private void listWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            /*
            if (rbt1.Checked)
            {
                setFilter(rbt1.Text);
            }
            else if (rbt2.Checked)
            {
                setFilter(rbt2.Text);
            }
            else
            {
                setFilter("Both");
            } */

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int rowindex = parcelGrid.CurrentCell.RowIndex;
            string name = (string)parcelGrid.Rows[rowindex].Cells[2].Value;
            string removedTime = "[Removed] " + DateTime.Now + "";
            int arrayIndex = getEntryIndex(name);


            parcelGrid.Rows.RemoveAt(rowindex);

            writeEntryToArchive(removedTime, arrayIndex);

            globals.building[getEntryIndex(name)]=null;

            writeArrayToFile();
            //updatePracelGrid();
        }

        private void btnOnePlus_Click(object sender, EventArgs e)
        {

            int rowindex = parcelGrid.CurrentCell.RowIndex;
            int columnindex = 1;
            int newValue = (int) parcelGrid.Rows[rowindex].Cells[columnindex].Value + 1;
            string name = (string) parcelGrid.Rows[rowindex].Cells[2].Value;

            parcelGrid.Rows[rowindex].Cells[columnindex].Value = newValue;

            globals.building[getEntryIndex(name)].qnt = newValue;

            writeArrayToFile();
        }
        private int getEntryIndex(string name)
        {
            int index;
            
            for (index = 0; index < globals.building.Length; index++)
            {
                if(globals.building[index] != null) { 
                    if (globals.building[index].name.Equals(name)) { break; }
                }
            }
            return index;
        }
        private void writeArrayToFile()
        {

            int index;

            //Clear File
            File.Create("InfoList.txt").Close();


            StreamWriter writer = new FileInfo("InfoList.txt").AppendText();

            for (index = 0; index < globals.building.Length; index++)
            {
                if (globals.building[index] != null)
                {
                    writer.WriteLine(globals.building[index].createFileLine());
                }
            }
            writer.Close();
        }
        private void writeEntryToArchive(string data, int index)
        {

            StreamWriter writer = new FileInfo("Archive.txt").AppendText();

            writer.WriteLine(data+"|"+globals.building[index].createFileLine());

            writer.Close();
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            int rowindex = parcelGrid.CurrentCell.RowIndex;
            int columnindex = 8;
            string value = parcelGrid.Rows[rowindex].Cells[columnindex].Value.ToString();
            string newValue = "";
            string name = (string)parcelGrid.Rows[rowindex].Cells[2].Value;
            
            newValue = value.Equals("TRA2") ? "TRA1" : "TRA2";

            parcelGrid.Rows[rowindex].Cells[columnindex].Value = newValue;

            globals.building[getEntryIndex(name)].building = newValue;

            writeArrayToFile();
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            int rowindex = parcelGrid.CurrentCell.RowIndex;
            string name = (string)parcelGrid.Rows[rowindex].Cells[2].Value;
            string deliveredTime = "[Delivered] " + DateTime.Now + "";
            int arrayIndex = getEntryIndex(name);
            
            parcelGrid.Rows.RemoveAt(rowindex);

            writeEntryToArchive(deliveredTime, arrayIndex);

            globals.building[arrayIndex] = null;

            writeArrayToFile();
        }
        public void updatePracelGrid()
        {
            if (rbt1.Checked)
            {
                setFilter(rbt1.Text);
            }
            else if (rbt2.Checked)
            {
                setFilter(rbt2.Text);
            }
            else
            {
                setFilter("Both");
            }
        }

        private void btnMinusOne_Click(object sender, EventArgs e)
        {
            int rowindex = parcelGrid.CurrentCell.RowIndex;
            int columnindex = 1;
            int newValue = (int)parcelGrid.Rows[rowindex].Cells[columnindex].Value - 1;
            string name = (string)parcelGrid.Rows[rowindex].Cells[2].Value;

            parcelGrid.Rows[rowindex].Cells[columnindex].Value = newValue;

            globals.building[getEntryIndex(name)].qnt = newValue;

            writeArrayToFile();
        }

        private void btnArchive_Click(object sender, EventArgs e)
        {
            ArchiveView arch = new ArchiveView();

            //Show the chield form
            arch.Show();
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            string message = "Do you really want to send the e-mail?";
            string caption = "Send Email";

            if (MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int index = 0; index < globals.building.Length; index++)
                {
                    if (globals.building[index] != null)
                    {
                        if (!globals.building[index].sent)
                        {
                            globals.building[index].sent = true;
                            writeArrayToFile();
                            parcelGrid.Rows.Clear();

                            updatePracelGrid();
                            sendEmail(index);
                        }
                    }
                }
            }


        }
        private void sendEmail(int index)
        {
            string[] fullName = globals.building[index].name.Split(' ');
            string name = fullName[1].Substring(0,1) + fullName[1].Substring(1).ToLower();
            string subject = String.Format("Parcel Available {0}", globals.building[index].building);
            string message = String.Format("Hello {0}!\n" +
                "You have a parcel for pickup!\n" +
                "Come down to {1} front desk with a piece of photo ID at your earliest convenience to claim your parcel." +
                "\n\n\n\n\n\n\n" +
                "Have a nice day!\n\n" +
                "Residence Service Representative\n" +
                "Sheridan College Residence - Trafalgar Campus\n" +
                "1410 Trafalgar Road\nOakville, ON  L6H 6W4\n" +
                "Phone: 905 - 815 - 4150 | Fax: 905 - 815 - 4155 | " +
                "Email: info.trafalgar @sheridanresidence.ca | " +
                "Web: www.sheridanresidence.ca", name, globals.building[index].building);

            SmtpClient client = new SmtpClient();
            client.Port = 25;
            client.Host = "smtp-mail.outlook.com";
            client.EnableSsl = true;
            client.Timeout = 10000;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential("[(1)insert Email Here<- Same email]", "[insert Password here]");

            MailMessage email = new MailMessage("[(1)insert Email Here <- Same email]", globals.building[index].email.ToLower());
            email.BodyEncoding = UTF8Encoding.UTF8;
            email.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

            email.Subject = subject;

            email.Body = message;


            client.Send(email);

            email.Dispose();
        }
    }
}
