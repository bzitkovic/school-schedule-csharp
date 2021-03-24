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
    // TODO - Rework update!
    public partial class SubjectsForm : Form
    {
        Subject chosenSubject = new Subject();
        User currentUser;
        public SubjectsForm(User user)
        {
            InitializeComponent();

            currentUser = user;

            ShowAllSubjects();

            FillComboBoxes();
        }

        private void FillComboBoxes()
        {
            List<DayOfWeek> days = new List<DayOfWeek>();
            List<Professor> professors = new List<Professor>();
            List<Hall> halls = new List<Hall>();
            List<Schedule> schedules = new List<Schedule>();

            cmbProfessor.DataSource = null;
            cmbHall.DataSource = null;
            cmbDay.DataSource = null;

            using (var context = new SchedulesEntities1())
            {
                foreach (Professor professor in context.Professors)
                {
                    professors.Add(professor);
                }

                foreach (Hall hall in context.Halls)
                {
                    halls.Add(hall);
                }

                foreach (Schedule schedule in context.Schedules.Where(x => x.IdUser == currentUser.Id))
                {
                    schedules.Add(schedule);
                }
            }

            cmbProfessor.DataSource = professors;
            cmbHall.DataSource = halls;
            cmbSchedule.DataSource = schedules;

            days.Add(DayOfWeek.Monday);
            days.Add(DayOfWeek.Tuesday);
            days.Add(DayOfWeek.Wednesday);
            days.Add(DayOfWeek.Thursday);
            days.Add(DayOfWeek.Friday);
            days.Add(DayOfWeek.Saturday);
            days.Add(DayOfWeek.Sunday);

            cmbDay.DataSource = days;
        }

        private void ShowAllSubjects()
        {
            dgvSubjects.DataSource = null;
            dgvSubjects.DataSource = GlobalConfig.Subject.GetAllSubjects();
            dgvSubjects.Columns["Schedules"].Visible = false;
            dgvSubjects.Columns["Professors"].Visible = false;
            dgvSubjects.Columns["Durations"].Visible = false;
            dgvSubjects.Columns["Halls"].Visible = false;
        }

        private void btnAddSubject_Click(object sender, EventArgs e)
        {
            if (btnAddSubject.Text == "Create subject")
            {
                GetAllData();

                GlobalConfig.Subject.CreateSubject(chosenSubject);                                
            }
            else
            {
                GetUpdatedData();

                GlobalConfig.Subject.UpdateSubject(chosenSubject);

                txtStartTime.Enabled = true;
                txtEndTime.Enabled = true;
                cmbDay.Enabled = true;            

                cmbProfessor.Enabled = true;

                cmbHall.Enabled = true;

                cmbSchedule.Enabled = true;

                FillComboBoxes();              

                btnAddSubject.Text = "Create subject";
            }

            ClearForm();

            ShowAllSubjects();
        }

        private void GetUpdatedData()
        {
            chosenSubject.Name = txtName.Text;
            chosenSubject.Ects = int.Parse(txtEcts.Text);
            chosenSubject.Description = rtxtDescription.Text;

       
            foreach (var duration in chosenSubject.Durations.ToList())
            {
                duration.StartTime = TimeSpan.Parse(txtStartTime.Text);
                duration.EndTime = TimeSpan.Parse(txtEndTime.Text);
                duration.Day = cmbDay.SelectedItem.ToString();
                chosenSubject.Durations.Clear();
                chosenSubject.Durations.Add(duration);
            }                       

            Professor professor = cmbProfessor.SelectedItem as Professor;
            chosenSubject.Professors.Clear();
            chosenSubject.Professors.Add(professor);

            Hall hall = cmbHall.SelectedItem as Hall;
            chosenSubject.Halls.Clear();
            chosenSubject.Halls.Add(hall);

            Schedule schedule = cmbSchedule.SelectedItem as Schedule;
            chosenSubject.Schedules.Clear();
            chosenSubject.Schedules.Add(schedule);
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtEcts.Text = "";
            rtxtDescription.Text = "";
            txtStartTime.Text = "";
            txtEndTime.Text = "";
        }

        private void GetAllData()
        {
            chosenSubject = new Subject();
            Duration duration = new Duration();
            List<Duration> durations = new List<Duration>();
            List<Professor> professors = new List<Professor>();
            List<Hall> halls = new List<Hall>();
            List<Schedule> schedules = new List<Schedule>();

            chosenSubject.Name = txtName.Text;
            chosenSubject.Ects = int.Parse(txtEcts.Text);
            chosenSubject.Description = rtxtDescription.Text;

            duration.Day = cmbDay.SelectedItem.ToString();
            duration.StartTime = TimeSpan.Parse(txtStartTime.Text);
            duration.EndTime = TimeSpan.Parse(txtEndTime.Text);
            durations.Add(duration);

            professors.Add(cmbProfessor.SelectedItem as Professor);

            halls.Add(cmbHall.SelectedItem as Hall);

            schedules.Add(cmbSchedule.SelectedItem as Schedule);

            chosenSubject.Durations.Clear();            
            chosenSubject.Durations.Add(durations[0]);

            chosenSubject.Halls.Clear();
            chosenSubject.Halls.Add(halls[0]);

            chosenSubject.Professors.Clear();
            chosenSubject.Professors.Add(professors[0]);

            chosenSubject.Schedules.Clear();
            chosenSubject.Schedules.Add(schedules[0]);                      
        }

        private Subject GetChosenSubject()
        {
            return dgvSubjects.CurrentRow.DataBoundItem as Subject;
        }

        private void btnShowSubjectDetails_Click(object sender, EventArgs e)
        {
            chosenSubject = GetChosenSubject();

            SubjectDetails frm = new SubjectDetails(chosenSubject);
            frm.Show();
        }

        private void btnEditSubject_Click(object sender, EventArgs e)
        {
            chosenSubject = GetChosenSubject();

            txtName.Text = chosenSubject.Name;
            txtEcts.Text = chosenSubject.Ects.ToString();
            rtxtDescription.Text = chosenSubject.Description;

            using (var context = new SchedulesEntities1())
            {
                chosenSubject = GetChosenSubject();
                context.Subjects.Attach(chosenSubject);

                var subject = context.Subjects.SingleOrDefault(x => x.Id == chosenSubject.Id);

                var query = from p in context.Subjects.Include("Durations").Include("Halls").Include("Professors")
                            where p.Id == chosenSubject.Id
                            select p;

                foreach (var s in query)
                {
                    foreach (var d in s.Durations)
                    {                        
                        var query2 = from p in context.Durations.Include("Subjects")
                                    where d.Id == p.Id
                                    select p;

                        foreach (var dd in query2)
                        {                                                      
                            txtStartTime.Text = dd.StartTime.ToString();
                            txtEndTime.Text = dd.EndTime.ToString();
                            cmbDay.SelectedItem = dd.Day;
                        }

                        txtStartTime.Enabled = false;
                        txtEndTime.Enabled = false;
                        cmbDay.Enabled = false;
                    }

                    cmbProfessor.DataSource = s.Professors.ToList();
                    cmbProfessor.Enabled = false;                  

                    cmbHall.DataSource = s.Halls.ToList();
                    cmbHall.Enabled = false;

                    cmbSchedule.DataSource = s.Schedules.ToList();
                    cmbSchedule.Enabled = false;
                }                                    
            }
           
            btnAddSubject.Text = "Update subject";
        }

        private void btnDeleteSubject_Click(object sender, EventArgs e)
        {
            chosenSubject = GetChosenSubject();

            GlobalConfig.Subject.DeleteSubject(chosenSubject);

            ShowAllSubjects();
        }
    }
}
