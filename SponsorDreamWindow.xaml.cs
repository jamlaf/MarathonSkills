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
using System.Windows.Threading;

namespace MarathonSkills.Windows
{
    /// <summary>
    /// Логика взаимодействия для SponsorDreamWindow.xaml
    /// </summary>
    public partial class SponsorDreamWindow : Window
    {
        DateTime endTime = new DateTime(2021, 5, 25, 14, 0, 0);
        DispatcherTimer mTimer = new DispatcherTimer();
        public SponsorDreamWindow()
        {
            InitializeComponent();

            mTimer.Tick += t_Tick;
            mTimer.Interval = new TimeSpan(0, 0, 1);
            mTimer.Start();
        }

        void t_Tick(object sender, EventArgs e)
        {
            TimeSpan timeResult = endTime - DateTime.Now;
            tbDataTimer.Text = timeResult.Days + " дней " + timeResult.Hours + " часов и " + timeResult.Minutes + " минут до старта марафона!";
        }

        private void btnBackToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mw = new MainWindow();
            this.Close();
            mw.Show();
        }
    }
}
