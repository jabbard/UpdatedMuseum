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
    public partial class WeeklyReport : Form
    {
        public WeeklyReport()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WeeklyReport_Load(object sender, EventArgs e)
        {
            String path = @"Data.csv";
            using (StreamReader reader = new StreamReader(path))
            {
                if (!File.Exists(path))
                {
                    this.Close();
                }

                while (!reader.EndOfStream)
                {

                }
            }
        }
    }
}
