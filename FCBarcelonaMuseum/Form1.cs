using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FCBarcelonaMuseum
{
    public partial class Form1 : Form
    {
        public List<Visitors> LsVisitors = new List<Visitors>();

        public Form1()
        {
            InitializeComponent();
            Load();
        }

        public void ToCSV(String data)
        {
            String path = @"Data.csv";
            if (!File.Exists(path))
            {
                File.Create(path);
            }

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine(data);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int cardNo = 0;
                String path = @"Data.csv";
                if (!File.Exists(path))
                {
                    File.Create(path);
                }
                using (StreamReader reader = new StreamReader(path))
                {
                    String line = "";
                    if (File.Exists(@"Data.csv"))
                    {
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            String[] rowData = line.Split(',');
                            cardNo = int.Parse(rowData[0]);
                        }

                        cardNo = ++cardNo;
                    }

                }

                String visitorName = txtName.Text;
                String phNo = txtPhNo.Text;
                String occupation = cmbOccupation.Text;
                String gender;

                if (radMale.Checked)
                {
                    gender = radMale.Text;
                }
                else
                {
                    gender = radFemale.Text;
                }
                DateTime inTime = DateTime.Now;
                DateTime outTime = default(DateTime);
                DayOfWeek day = inTime.DayOfWeek;
                Visitors visitors = new Visitors(cardNo, visitorName, phNo, occupation, gender, inTime, outTime, day);
                LsVisitors.Add(visitors);
                String data = cardNo + "," + visitorName + "," + phNo + "," + occupation + "," + gender + "," + inTime + "," +outTime+","+ day;
                ToCSV(data);



            }
            catch (Exception f)
            {
                MessageBox.Show("The values entered are either missing or incorrect!");
            }


        }


        public void Load()
        {
            String path = @"Data.csv";
            using (StreamReader reader = new StreamReader(path))
            {
                String line = "";
                if (File.Exists(path))
                {
                    while (!reader.EndOfStream)
                    {
                        line = reader.ReadLine();
                        String[] rowData = line.Split(',');
                        int rowNum = dataGridTable.Rows.Add();
                        DataGridViewRow row = dataGridTable.Rows[rowNum];

                        row.Cells["ColnCardNum"].Value = rowData[0];
                        row.Cells["ColnFullName"].Value = rowData[1];
                        row.Cells["ColnPhNum"].Value = rowData[2];
                        row.Cells["ColnOccupation"].Value = rowData[3];
                        row.Cells["ColnGender"].Value = rowData[4];
                        row.Cells["ColnInTime"].Value = rowData[5];
                        row.Cells["ColnDay"].Value = rowData[7];

                        Visitors visitors = new Visitors(int.Parse(rowData[0]), rowData[1], rowData[2], rowData[3], rowData[4], DateTime.Parse(rowData[5]), DateTime.Parse(rowData[6]), DateTime.Parse(rowData[5]).DayOfWeek);

                        LsVisitors.Add(visitors);

                    }


                }

            }
        }
    }
}
