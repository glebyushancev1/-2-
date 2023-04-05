using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfLR2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        ClsZNAK chel = new ClsZNAK();

        private void BtnSolve_Click(object sender, RoutedEventArgs e)
        {
            chel.Fam = TxtInputFam.Text;
            chel.Name = TxtInputName.Text;
            chel.Znak = TxtInputZnak.Text;
            chel.Date = (DateTime)TxtInputDate.SelectedDate;
            LstResult.Items.Clear();
            LstResult.Items.Add(chel.PrintToScreen());
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == false)
                return;
            chel.SaveToFile(saveFileDialog.FileName);

        }
    }
}
