﻿using System;
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
using Xceed.Wpf.Toolkit;

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
            tpiStartTime.Value = DateTime.Now;
            tpiEndTime.Value = DateTime.Now;
        }

        //Eine Änderung

        private void FollowUp_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)(chbFollowUp.IsChecked))
            {
                // MessageBox.Show("Checkbock aktiv!");
                txbFollowUp.Visibility = Visibility.Visible;
                gridFollowUpHead.Visibility = Visibility.Visible;
                gridFollowUpFields.Visibility = Visibility.Visible;
            }
            else
            {
                // MessageBox.Show("Checkbock deaktiviert!");
                txbFollowUp.Visibility = Visibility.Collapsed;
                gridFollowUpHead.Visibility = Visibility.Collapsed;
                gridFollowUpFields.Visibility = Visibility.Collapsed;
            }
        }

        private void tpiStartTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            DateTime endTime = new DateTime();
            DateTime startTime = new DateTime();
            TimeSpan durationTime = new TimeSpan();
            startTime = (DateTime)tpiStartTime.Value;

            if (tpiEndTime.Value != null)
            {
                endTime = (DateTime)tpiEndTime.Value;
                durationTime = endTime.Subtract(startTime);
                txtDurationTime.Text = durationTime.ToString(@"d\.hh\:mm");
            }
            else
            {
                tpiEndTime.Value = startTime;
            }
            //EndTime_Changed(tpiEndTime, tpiEndTime);
        }

        private void tpiEndTime_ValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            DateTime endTime = new DateTime();
            DateTime startTime = new DateTime();
            TimeSpan durationTime = new TimeSpan();
            endTime = (DateTime)tpiEndTime.Value;

            if (tpiStartTime.Value != null)
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

        private void chbBASCase_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)(chbBASCase.IsChecked))
            {
                // MessageBox.Show("Checkbock aktiv!");
                txbBASCase.Visibility = Visibility.Visible;
                gridBASCaseHead.Visibility = Visibility.Visible;
                gridBASCaseFields.Visibility = Visibility.Visible;
            }
            else
            {
                // MessageBox.Show("Checkbock deaktiviert!");
                txbBASCase.Visibility = Visibility.Collapsed;
                gridBASCaseHead.Visibility = Visibility.Collapsed;
                gridBASCaseFields.Visibility = Visibility.Collapsed;
            }

        }



        /*
        private void EndTime_Changed(DateTimePicker tpiEndTime1, DateTimePicker tpiEndTime2)
        {
            throw new NotImplementedException();
        }
        */
    }
}
