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

namespace EF_HW2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            //using (ApplicationContext context = new ApplicationContext())
            //{
            //    context.Student.AddRange(
            //        new Entities.Student { FirstName = "Евгений", LastName = "Онегин", BirthDate = DateTime.Parse("1976-05-21"), PhoneNumber = "+79912852339" },
            //        new Entities.Student { FirstName = "Сиро", LastName = "Кобаяси", BirthDate = DateTime.Parse("1941-03-25"), PhoneNumber = "+79912852339" },
            //        new Entities.Student { FirstName = "Август", LastName = "Куратов", BirthDate = DateTime.Parse("1952-04-12"), PhoneNumber = "+79292287603" });
                

            //    context.Card.AddRange(
            //        new Entities.Card { SerialNumber = 021016 },
            //        new Entities.Card { SerialNumber = 021017 },
            //        new Entities.Card { SerialNumber = 021018 }); 
            //    context.SaveChanges();
            //}
            InitializeComponent();
        }
    }
}
