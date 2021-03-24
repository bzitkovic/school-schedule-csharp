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
    public partial class Professors : Form
    {
        Professor chosenProfessor;
        public Professors()
        {
            InitializeComponent();

            ShowAllProfessors();
        }
        private void ShowAllProfessors()
        {
            dgvProfessors.DataSource = null;
            dgvProfessors.DataSource = GlobalConfig.Professor.GetAllProfessors();
            dgvProfessors.Columns["Subjects"].Visible = false;
        }

        private void btnAddProfessor_Click(object sender, EventArgs e)
        {
            if (btnAddProfessor.Text == "Add professor")
            {
                if (CheckUserInput())
                {
                    GlobalConfig.Professor.CreateProfessor(GetAllData());
                }
                else
                {
                    MessageBox.Show("Email is not valid!");
                }             
            }
            else
            {
                if (CheckUserInput())
                {
                    chosenProfessor.Name = txtName.Text;
                    chosenProfessor.Surname = txtSurname.Text;
                    chosenProfessor.Email = txtEmail.Text;

                    GlobalConfig.Professor.UpdateProfessor(chosenProfessor);

                    btnAddProfessor.Text = "Add professor";
                }
                else
                {
                    MessageBox.Show("Email is not valid!");
                }              
            }

            ClearForm();

            ShowAllProfessors();
        }

        private bool CheckUserInput()
        {
            bool output = true;           

            if (!txtEmail.Text.Contains("@"))
            {
                output = false;
            }

            return output;
        }

        private Professor GetAllData()
        {
            Professor professor = new Professor();

            professor.Name = txtName.Text;
            professor.Surname = txtSurname.Text;
            professor.Email = txtEmail.Text;

            return professor;
        }

        private void ClearForm()
        {
            txtName.Text = "";
            txtSurname.Text = "";
            txtEmail.Text = "";
        }

        private void btnEditProfessor_Click(object sender, EventArgs e)
        {
            chosenProfessor = GetChosenProfessor();

            txtName.Text = chosenProfessor.Name;
            txtSurname.Text = chosenProfessor.Surname;
            txtEmail.Text = chosenProfessor.Email;

            btnAddProfessor.Text = "Update professor";
        }

        private Professor GetChosenProfessor()
        {
            return dgvProfessors.CurrentRow.DataBoundItem as Professor;
        }

        private void btnDeleteProfessor_Click(object sender, EventArgs e)
        {
            chosenProfessor = GetChosenProfessor();

            GlobalConfig.Professor.DeleteProfessor(chosenProfessor);

            ShowAllProfessors();
        }       
    }
}
