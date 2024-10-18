using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SdfHazirliq
{
    public partial class StudentForm : Form
    {
        IstifadecilerAdd<Student> istifadeciler;
        AddJson<Student> add;
        
        public StudentForm()
        {
            InitializeComponent();
            istifadeciler = new Qeydiyyat<Student>();
            add = new AddJson<Student>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ReturnHome.ReturnHomePage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = textBox1.Text;
            student.lastName = textBox2.Text;
            student.sinifNumber = textBox3.Text;

            istifadeciler.add(student);


            string filePath = "student.json";


            add.addJson(filePath, student);

        }
       
    }
}
