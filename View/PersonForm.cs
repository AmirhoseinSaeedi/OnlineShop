using ViewModel;
using ViewModel.Dtos;

namespace View
{
    public partial class PersonForm : Form
    {
        private readonly PersonViewModel _personViewModel;
        public PersonForm()
        {
            InitializeComponent();
            _personViewModel = new PersonViewModel();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            dgvPerson.DataSource = _personViewModel.FillGrid();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var personSaveDto = new PersonSaveDto()
            {
                FirstName = personTxtFirstName.Text,
                LastName = personTxtLastName.Text,

            };
            _personViewModel.Save(personSaveDto);
            MessageBox.Show("New person saved succesfully");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void personBtnDelete_Click(object sender, EventArgs e)
        {
            string input = personTxtId.Text.ToString();
            int id = Int32.Parse(input);
            var personDeleteDto = new PersonDeleteDto()
            {
                Id = id,
            };
            _personViewModel.Remove(personDeleteDto);
            MessageBox.Show("person deleted");
        }
    }
}