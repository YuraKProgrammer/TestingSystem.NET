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
            var test = new Testing("Математика 1 класс", Difficulty.Normal);
            test.id = 1;
            test.AddQuestion(new Question(QuestionType.Line, "абв", "абв"));
            test.AddQuestion(new Question(QuestionType.Line, "абв", "абв"));
            testings.Add(test);
            lb.ItemsSource = testings;
        }

        public void _lb_MouseDoubleClick(object sender, RoutedEventArgs e)
        {
        }
    }
}
