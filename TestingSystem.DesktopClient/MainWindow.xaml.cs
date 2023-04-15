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
using TestingSystem.Models;

namespace TestingSystem.DesktopClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Testing> testings = new List<Testing>();
            var test = new Testing("Математика 1 класс", Difficulty.Newbie);
            test.id = 1;
            test.AddQuestion(new Question(QuestionType.Line, "абв", "абв"));
            test.AddQuestion(new Question(QuestionType.Line, "абв", "абв"));
            testings.Add(test);
            var test2 = new Testing("Математика 4 класс", Difficulty.Easy);
            testings.Add(test2);
            var test3 = new Testing("Математика 6 класс", Difficulty.Normal);
            testings.Add(test3);
            var test4 = new Testing("Математика 8 класс", Difficulty.Hard);
            testings.Add(test4);
            var test5 = new Testing("Математика 10 класс", Difficulty.Expert);
            testings.Add(test5);
            var test6 = new Testing("Русский язык 11 класс", Difficulty.Expert);
            testings.Add(test6);
            lb.ItemsSource = testings;
        }

        public void _lb_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
        }
    }
}
