using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Parcel_Log
{
    public class Parcel
    {
        public string date { get; set; }
        public string name { get; set; }
        public int qnt { get; set; }
        public string suite { get; set; }
        public string email { get; set; }
        public bool sent { get; set; }
        public string staffInitials { get; set; }
        public string building { get; set; }
        public string notes { get; set; }
        public string box { get; set; }

         public string calculateBox(string firstLetter)
        {

            string b = "---";
            int count = 0;
            using (StreamReader reader = new StreamReader("box.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split('|');
                    count++;
                }
            }

            string[,] alphabeth = new string[count,2];

            count = 0;
            using (StreamReader reader = new StreamReader("box.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split('|');

                    alphabeth[count, 0] = line[0];
                    alphabeth[count, 1] = line[1];

                    count++;
                }
            }

            for (int i = 0; i < alphabeth.GetLength(0); i++)
            {
                if (firstLetter == alphabeth[i,0])
                {
                    b = alphabeth[i, 1];
                    break;
                }
            }

            return b;
        }

        public string createFileLine()
        {
            return "" + this.date +"|" +this.qnt + "|" + this.name + "|" + this.suite + "|" 
                      + this.email + "|" + this.box + "|" + this.sent+ "|" + this.staffInitials 
                      + "|" + this.building + "|" + this.notes;
        }
    }

   
}
