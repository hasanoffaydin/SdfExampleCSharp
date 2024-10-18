using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SdfHazirliq
{
    internal class ReturnHome
    {
        public static void ReturnHomePage()
        {
            foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
            {
                if (!(form is Form1))
                {
                    form.Close();
                }
            }
            Form1 form1 = new Form1();
            form1.Show();

        }
    }
}
