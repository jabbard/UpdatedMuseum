using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            LoadGrid();
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
                Regex rx = new Regex(@"^98*([0-9]{8})$");
                Regex rgx = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                
                
                if (!rx.IsMatch(txtPhNo.Text) || cmbOccupation.SelectedText.Equals("Select an occupation") || !rgx.IsMatch(txtEmail.Text))
                {
                    btnClearAll.PerformClick();
                }
                else
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
                    String email;
                    if (txtEmail.Text.Equals(""))
                    {
                        MessageBox.Show("The name field is empty!");
                        return;
                    }
                    else
                    {
                        email = txtEmail.Text;
                    }
                    String occupation;
                    if(cmbOccupation.SelectedText.Equals("Select an occupation"))
                    {
                        MessageBox.Show("Please select an occupation");
                        return; 
                    } else
                    {
                        occupation = cmbOccupation.Text;
                    }

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
                    TimeSpan opens = new TimeSpan(10, 0, 0);
                    TimeSpan closes = new TimeSpan(17, 0, 0);
                    DayOfWeek day = inTime.DayOfWeek;
                    //if(day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
                    //{
                    //    MessageBox.Show("The museum is closed.");
                    //} else if(inTime.TimeOfDay > opens && inTime.TimeOfDay < closes) {
                    //    return;
                    //} else
                    //{
                    //    MessageBox.Show("The musuem is now close, please visit between 10 AM and 5 PM");
                    //}
                    String visitorName;
                    if (txtName.Text.Equals(""))
                    {
                        MessageBox.Show("The name field is empty!");
                        return;
                    }
                    else
                    {
                        visitorName = txtName.Text;
                    }
                    String phNo;
                    if (txtPhNo.Text.Equals(""))
                    {
                        MessageBox.Show("The name field is empty!");
                        return;
                    }
                    else
                    {
                        phNo = txtPhNo.Text;
                    }
                    Visitors visitors = new Visitors(cardNo, visitorName, phNo, email, occupation, gender, inTime, outTime, day);
                    LsVisitors.Add(visitors);
                    String data = cardNo + "," + visitorName + "," + phNo + "," + email + "," + occupation + "," + gender + "," + inTime + "," + outTime + "," + day;
                    ToCSV(data);
                    LoadGrid();
                   
                }


            }
            catch (Exception f)
            {
                MessageBox.Show("The values entered are either missing or incorrect!");
            }


        }


        public void LoadGrid()
        {
            //try
            //{
                String path = @"Data.csv";
                using (StreamReader reader = new StreamReader(path))
                {
                    String line = "";
                    if (File.Exists(path))
                    {
                        dataGridTable.Rows.Clear();
                        while (!reader.EndOfStream)
                        {
                            line = reader.ReadLine();
                            String[] rowData = line.Split(',');
                            int rowNum = dataGridTable.Rows.Add();
                            DataGridViewRow row = dataGridTable.Rows[rowNum];


                            row.Cells["ColnCardNum"].Value = rowData[0];
                            row.Cells["ColnFullName"].Value = rowData[1];
                            row.Cells["ColnPhNum"].Value = rowData[2];
                            row.Cells["ColnEmail"].Value = rowData[3];
                            row.Cells["ColnOccupation"].Value = rowData[4];
                            row.Cells["ColnGender"].Value = rowData[5];
                            row.Cells["ColnInTime"].Value = DateTime.Parse(rowData[6]).ToString("hh:mm tt");
                            DateTime outTime = DateTime.Parse(rowData[7]);
                            if (!outTime.Equals(default(DateTime)))
                            {
                                row.Cells["ColnOutTime"].Value = outTime.ToString("hh:mm tt");
                            }
                            row.Cells["ColnDay"].Value = rowData[8];

                            Visitors visitors = new Visitors(int.Parse(rowData[0]), rowData[1], rowData[2], rowData[3], rowData[4], rowData[5], DateTime.Parse(rowData[6]), DateTime.Parse(rowData[7]), DateTime.Parse(rowData[6]).DayOfWeek);

                            LsVisitors.Add(visitors);

                        }


                    }

                }
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show("Error while loading data from the csv file.");
            //}
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtPhNo.Text = "";
            cmbOccupation.SelectedItem = null;
            cmbOccupation.SelectedText = "Select an occupation";
            txtEmail.Text = "";
            radMale.Checked = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbOccupation.SelectedItem = null;
            cmbOccupation.SelectedText = "Select an occupation";
        }

        private void btnCheckIn_Click(object sender, EventArgs e)
        {
            try
            {
                int cardNo = int.Parse(txtCardNo.Text);
                int cNo = 0;
                String name = "";
                String phNo = "";
                String email = "";
                String occupation = "";
                String gender = "";
                DateTime inTime = DateTime.Now;
                DateTime outTime = default(DateTime);
                DayOfWeek day = inTime.DayOfWeek;
                foreach (Visitors v in LsVisitors)
                {
                    if (v.CardNo == cardNo && !v.OutTime.Equals(default(DateTime)))
                    {
                        cNo = v.CardNo;
                        name = v.Name;
                        phNo = v.PhNo;
                        email = v.Email;
                        occupation = v.Occupation;
                        gender = v.Gender;
                        txtCardNo.Text = "";
                    } else if (v.CardNo == cardNo && v.OutTime.Equals(default(DateTime)))
                    {
                        MessageBox.Show("This user has not exited previously.");
                        txtCardNo.Text = "";
                        return;
                    }
                }
                Visitors visit = new Visitors(cNo, name, phNo, email, occupation, gender, inTime, outTime, day);
                LsVisitors.Add(visit);
                String data = cNo + "," + name + "," + phNo + "," + email + "," + occupation + "," + gender + "," + inTime + "," + outTime + "," + day;
                ToCSV(data);
                LoadGrid();
            } catch (Exception a)
            {
                MessageBox.Show("Enter correct value!");
                txtCardNo.Text = "";
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //try
            //{
                int cardNo = int.Parse(txtCardNoOut.Text);
                
                String[] lines = File.ReadAllLines(@"Data.csv");
                using (StreamWriter writer = new StreamWriter(@"Data.csv"))
                {
                    for (int currentLine = 1; currentLine <= lines.Length; ++currentLine)
                    {
                        if (cardNo == LsVisitors[currentLine-1].CardNo && LsVisitors[currentLine-1].OutTime.Equals(default(DateTime)))
                        {
                            LsVisitors[currentLine - 1].OutTime = DateTime.Now;
                            writer.WriteLine(LsVisitors[currentLine - 1].CardNo + "," + LsVisitors[currentLine - 1].Name + "," + LsVisitors[currentLine - 1].PhNo + "," + LsVisitors[currentLine - 1].Email + "," + LsVisitors[currentLine - 1].Occupation + "," + LsVisitors[currentLine - 1].Gender + "," + LsVisitors[currentLine - 1].InTime + "," + DateTime.Now + "," + LsVisitors[currentLine - 1].Day);
                            txtCardNoOut.Text = "";
                        }
                        else
                        {
                            writer.WriteLine(lines[currentLine - 1]);
                            MessageBox.Show("The user has already checked out.");
                            txtCardNoOut.Text = "";
                        }
                    }
                }
            LoadGrid();


            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show("btnCheckOut");   
            //}
            
            
        }

       
    }
}
