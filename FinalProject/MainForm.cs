using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void uxMainLogBtn_Click(object sender, EventArgs e)
        {
            DailyLogForm dailyLogForm = new DailyLogForm();
            dailyLogForm.Show();
        }

        private void uxMainScheduleBtn_Click(object sender, EventArgs e)
        {
            //ScheduleForm 
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.Show();
        }
    }
}
