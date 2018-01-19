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

namespace ReactiveCases
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Eine Änderung
        private void EndTime_Changed(object sender, RoutedEventArgs e)
        {
            DateTime endTime = new DateTime();
            DateTime startTime = new DateTime();
            TimeSpan durationTime = new TimeSpan();
            endTime = (DateTime)tpiEndTime.Value;

            if (tpiStartTime != null)
            {
                startTime = (DateTime)tpiStartTime.Value;
                durationTime = endTime.Subtract(startTime);
                txtDurationTime.Text = durationTime.ToString(@"d\.hh\:mm");
            }
            else
            {
                tpiStartTime.Value = endTime;
            }
        }

        private void FollowUp_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)(chbFollowUp.IsChecked))
            {
               // MessageBox.Show("Checkbock aktiv!");
                gridFollowUpHead.Visibility = Visibility.Visible;
                gridFollowUpFields.Visibility = Visibility.Visible;
            }
            else
            {
               // MessageBox.Show("Checkbock deaktiviert!");
                gridFollowUpHead.Visibility = Visibility.Hidden;
                gridFollowUpFields.Visibility = Visibility.Hidden;
            }
        }

        private void tpiStartTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if(tpiEndTime==null)
            {
                return;
            }
            //EndTime_Changed();
        }
    }
}
