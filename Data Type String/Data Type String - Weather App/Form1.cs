using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Type_String___Weather_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string day = tbDay.Text;
            string temp = tbTemp.Text.ToString();
            lblAll.Visible = true;
            lblAll.Text = $"Температурата в {day} е {temp} градуса.";
        }
    }
}