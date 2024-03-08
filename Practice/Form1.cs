namespace Practice
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btncreate_Click(object sender, EventArgs e)
		{
			Student student_1 = new Student();

			student_1.Name = txtName.Text;
			student_1.Paternalsurname = TxtPaternalSurname.Text;
			student_1.Mothersurname = txtMorherSurname.Text;
			student_1.Dath_birth = (DateTime)Dtdatebirth.Value;
			student_1.Student_enrollment = txtidnumber.Text;
			student_1.University_career = txtcareer.Text;
			student_1.Average_rating = (double)Numupdown_average.Value;
			lbstudentinformation.Text = student_1.ToString();

		}

		
	}
}
