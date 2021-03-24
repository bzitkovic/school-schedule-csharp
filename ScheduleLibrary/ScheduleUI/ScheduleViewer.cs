using ScheduleLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScheduleUI
{
    public partial class ScheduleViewer : Form
    {
        Schedule selectedSchedule; 
        public ScheduleViewer(Schedule schedule)
        {           
            InitializeComponent();

            selectedSchedule = schedule;

            dgvSheduleSubjects.DataSource = ScheduleLogic.GetSelectedScheduleSubjects(selectedSchedule);

            HideUnnecessaryFields();

            FillCmbWitDays();            
        }

        private void FillCmbWitDays()
        {
            List<DayOfWeek> days = new List<DayOfWeek>();

            days.Add(DayOfWeek.Monday);
            days.Add(DayOfWeek.Tuesday);
            days.Add(DayOfWeek.Wednesday);
            days.Add(DayOfWeek.Thursday);
            days.Add(DayOfWeek.Friday);
            days.Add(DayOfWeek.Saturday);
            days.Add(DayOfWeek.Sunday);

            cmbFilterByDay.DataSource = days;
        }

        private void HideUnnecessaryFields()
        {
            dgvSheduleSubjects.Columns["Schedules"].Visible = false;
            dgvSheduleSubjects.Columns["Professors"].Visible = false;
            dgvSheduleSubjects.Columns["Durations"].Visible = false;
            dgvSheduleSubjects.Columns["Halls"].Visible = false;
        }       

        private void ScheduleViewer_Load(object sender, EventArgs e)
        {
            lblSheduleName.Text = selectedSchedule.Name;
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            Subject chosenSubject = GetChosenSubject();

            if(chosenSubject != null)
            {
                SubjectDetails frm = new SubjectDetails(chosenSubject);

                frm.Show();
            }         
        }

        private Subject GetChosenSubject()
        {
            return (dgvSheduleSubjects.CurrentRow != null ? dgvSheduleSubjects.CurrentRow.DataBoundItem as Subject : null);
        }

        private void cmbFilterByDay_SelectedIndexChanged(object sender, EventArgs e)
        {           
            dgvSheduleSubjects.DataSource = ScheduleLogic.GetFilteredScheduleSubjects(selectedSchedule, cmbFilterByDay.SelectedItem.ToString());
        }

        private void btnDeleteSchedule_Click(object sender, EventArgs e)
        {
            ScheduleLogic.DeleteSchedule(selectedSchedule);

            this.Close();
        }
    }
}
