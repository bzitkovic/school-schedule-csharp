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
    public partial class SubjectDetails : Form
    {
        private Subject chosenSubject;
        public SubjectDetails(Subject subject)
        {
            InitializeComponent();

            chosenSubject = subject;

            FillFormWithData();

        }              
      
        private void FillFormWithData()
        {
            List<Subject> subjects = GetInfoForChosenSubject();       

            foreach (Subject subject in subjects)
            {
                foreach (Professor professor in subject.Professors)
                {
                    txtProfessorName.Text = professor.Name;
                    txtProfessorSurname.Text = professor.Surname;
                }

                foreach (Duration duration in subject.Durations)
                {
                    txtDay.Text = duration.Day;
                    txtStartTime.Text = duration.StartTime.ToString();
                    txtEndTime.Text = duration.EndTime.ToString();
                }

                foreach (Hall hall in subject.Halls)
                {
                    txtHall.Text = hall.Name;
                }
            }         
        }

        private List<Subject> GetInfoForChosenSubject()
        {
            List<Subject> subjects = new List<Subject>();

            using (var context = new SchedulesEntities1())
            {
                context.Subjects.Attach(chosenSubject);

                var query = (from p in context.Subjects.Include("Durations").Include("Professors").Include("Halls")
                             where p.Id == chosenSubject.Id
                             select p).FirstOrDefault();

                subjects.Add(query);
            }

            return subjects;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
