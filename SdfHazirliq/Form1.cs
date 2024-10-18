namespace SdfHazirliq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm studentForm = new StudentForm();
            studentForm.Show();
            this.Hide();
        }
    }
}
