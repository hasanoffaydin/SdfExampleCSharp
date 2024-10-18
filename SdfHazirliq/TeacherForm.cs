using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SdfHazirliq
{
    public partial class TeacherForm : Form
    {
        IstifadecilerAdd<Teacher> istifadeciler;
        AddJson<Teacher> add;
        public TeacherForm()
        {
            InitializeComponent();
            istifadeciler = new Qeydiyyat<Teacher>();
            add = new AddJson<Teacher>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnHome.ReturnHomePage();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.name = textBox1.Text;
            teacher.lastName = textBox2.Text;
            teacher.description = textBox3.Text;

            istifadeciler.add(teacher);

            string filePath = "teacher.json";

            add.addJson(filePath, teacher);

        }
    }
}
