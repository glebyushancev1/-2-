using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLR2
{
    internal class ClsZNAK
    {
        //поля
        private string fam;
        private string name;
        private DateTime date;
        private string znak;

        // свойства для доступа к полям
        public string Fam
        {
            get { return fam; }//возвращает значение поля
            set { fam = value; } //устанавливает значение поля
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Znak
        {
            get { return znak; }
            set { znak = value; }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        //методы 
        //конструктор без параметров задает значения полей по умолчанию
        public ClsZNAK()
        {
            fam = "";
            name = "";
            znak = "";
            date = new DateTime(2001, 01, 01);
        }
        //конструктор с параметрами
        public ClsZNAK(string f, DateTime d, string z,
            string n)
        {
            fam = f;
            date = d;
            name = n;
            znak = z;
        }
        //метод вывода на экран
        public string PrintToScreen()
        {
            string line = $"{fam} {name}" + "\n";
            line += $"Родился {date}" + "\n";
            line += $"Год поступления {znak}";
            return line;
        }
        public void SaveToFile(string filename)
        {
            StreamWriter streamWriter = new StreamWriter(filename, true, Encoding.Default);
            streamWriter.WriteLine("Личные данные человека");
            streamWriter.WriteLine($"Фамилия: {fam}");
            streamWriter.WriteLine($"Имя: {name}");
            streamWriter.WriteLine($"Дата рождения: {date}");
            streamWriter.WriteLine($"должность: {znak}");
            streamWriter.Close();
        }
    }
}
