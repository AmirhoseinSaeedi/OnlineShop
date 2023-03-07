using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModel;
using ViewModel.Dtos;

namespace View
{
    public partial class PersonsForm : Form
    {
        private readonly PersonViewModel _personViewModel;
        public PersonsForm()
        {
            InitializeComponent();
            _personViewModel = new PersonViewModel();
        }

        private void PersonRefreshBtn_Click(object sender, EventArgs e)
        {
            PersonDVG.DataSource = _personViewModel.FillGrid();
        }

        private void PersonSaveBtn_Click(object sender, EventArgs e)
        {
            var personSaveDto = new PersonSaveDto()
            {
                FirstName = PersonFirsNameTxt.Text,
                LastName = PersonLastNameTxt.Text,

            };
            _personViewModel.Save(personSaveDto);
            MessageBox.Show("New person saved succesfully");
        }

        private void PersonDeleteBtn_Click(object sender, EventArgs e)
        {
            if (PersonDVG.CurrentRow != null)
            {
                var id = PersonDVG.CurrentRow.Cells[0].Value;
                var personDeleteDto = new PersonDeleteDto()
                {
                    Id = (int)id,
                };
                _personViewModel.Remove(personDeleteDto);
                MessageBox.Show("person deleted");
            }
            else
            {
                MessageBox.Show("Pelese select person you want to delete!!!");
            }
            
        }

        private void PersonUpdateBtn_Click(object sender, EventArgs e)
        {
            if (PersonDVG.CurrentRow != null) {
                var id = PersonDVG.CurrentRow.Cells[0].Value;
                var firstName = PersonFirsNameTxt.Text.ToString();
                var lastName = PersonLastNameTxt.Text.ToString();
                var personUpdateDto = new PersonUpdateDto()
                {
                    Id = (int)id,
                    NewFirstName = firstName,
                    NewLastName = lastName,
                };
                _personViewModel.Update(personUpdateDto);
                MessageBox.Show("Updated succesfully");
            }
            else
            {
                MessageBox.Show("Pelese select person you wante to update!!!");
            }
        }

        private void PersonBackBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            MainForm mainForm = new MainForm();
            mainForm.Show();
        }
    }
}
