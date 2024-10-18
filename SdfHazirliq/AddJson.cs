using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SdfHazirliq
{
    internal class AddJson<T>
    {
        public void addJson(String path,T t)
        {
            string json = JsonSerializer.Serialize(t);
            File.AppendAllText(path, json + Environment.NewLine);

            MessageBox.Show("Added and saved to file successfully.");
        }
    }
}
