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
    public partial class ArchiveView : Form
    {
        public ArchiveView()
        {
            InitializeComponent();
        }

        private void ArchiveView_Load(object sender, EventArgs e)
        {
            int i = 0;
            using (StreamReader reader = new StreamReader("Archive.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split('|');

                    dgArchive.Rows.Add(line[0], line[1], line[2], line[3], line[4], line[5], line[6], line[7], line[8], line[9], line[10]);
                    i++;
                }
            }
        }
    }
}
