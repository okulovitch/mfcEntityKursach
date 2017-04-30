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
using System.Windows.Shapes;

namespace kursachMain.Windows
{
    /// <summary>
    /// Логика взаимодействия для Students.xaml
    /// </summary>
    public partial class Students : Window
    {
        public Students()
        {
            InitializeComponent();
        }
        kursachDb db = new kursachDb();
        Группы grups= new Группы();

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            grups.НомерГруппы = nomberGr.Text;
            grups.ФИОКуратора = Kurator.Text;
            grups.ФИОСтаросты = Starosta.Text;
            db.Grups.Add(grups);
            db.SaveChanges();
            MessageBox.Show("saved");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Addres_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void TabControl_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
