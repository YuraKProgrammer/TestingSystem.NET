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

namespace TestingSystem.DesktopClient.UserControls
{
    /// <summary>
    /// Interaction logic for TestingControl.xaml
    /// </summary>
    public partial class TestingControl : UserControl
    {
        private Testing _testing;
        public Testing Testing
        {
            get
            {
                return _testing;
            }
            set
            {
                _testing = value;
                _name.Text = _testing.Name;
                _questionsCount.Text = _testing.GetQuestionsCount().ToString() + " вопросов";
                var ts = _testing.Time;
                if (ts.Equals(new TimeSpan(0, 0, 0)))
                {
                    _time.Text = "Время не ограничено";
                }
                else
                {
                    _time.Text = "Время: " + _testing.Time.ToString();
                }
                string s = "Новичок";
                var b = Brushes.Gray;
                switch (_testing.GetDifficulty())
                {
                    case Difficulty.Newbie:
                        s = "Новичок";
                        b = Brushes.Gray;
                        break;
                    case Difficulty.Easy:
                        s = "Лёгкий";
                        b = Brushes.Green;
                        break;
                    case Difficulty.Normal:
                        s = "Нормальный";
                        b = Brushes.Yellow;
                        break;
                    case Difficulty.Hard:
                        s = "Сложный";
                        b = Brushes.Red;
                        break;
                    case Difficulty.Expert:
                        s = "Эксперт";
                        b = Brushes.Blue;
                        break;
                }
                _difficulty.Text = s;
                _difficulty.Foreground = b;
            }
        }
        private void TestingControl_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Testing = DataContext as Testing;
        }

        public TestingControl(Testing testing) : this()
        {
            InitializeComponent();
            _testing = testing;
            _name.Text = testing.Name;
            var ts = testing.Time;
            if (ts.Equals(new TimeSpan(0, 0, 0)))
            {
                _time.Text = "Время не ограничено";
            }
            else
            {
                _time.Text = "Время: " + testing.Time.ToString();
            }
            _questionsCount.Text = testing.GetQuestionsCount().ToString() + " вопросов";
            string s = "Новичок";
            var b = Brushes.Gray;
            switch (testing.GetDifficulty())
            {
                case Difficulty.Newbie:
                    s = "Новичок";
                    b = Brushes.Gray;
                    break;
                case Difficulty.Easy:
                    s = "Лёгкий";
                    b = Brushes.Green;
                    break;
                case Difficulty.Normal:
                    s = "Нормальный";
                    b = Brushes.Yellow;
                    break;
                case Difficulty.Hard:
                    s = "Сложный";
                    b = Brushes.Red;
                    break;
                case Difficulty.Expert:
                    s = "Эксперт";
                    b = Brushes.Blue;
                    break;
            }
            _difficulty.Text = s;
            _difficulty.Foreground = b;
        }

        public TestingControl()
        {
            InitializeComponent();
            DataContextChanged += TestingControl_DataContextChanged;
        }
    }
}
