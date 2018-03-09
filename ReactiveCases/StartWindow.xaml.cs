using System.Data;
using System.Windows;

namespace ReactiveCases
{
    /// <summary>
    /// Interaktionslogik für StartWindow.xaml
    /// </summary>
    public partial class StartWindow : Window
    {
        public StartWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click_NewCase(object sender, RoutedEventArgs e)
        {
            CreateWindow createWindow = new CreateWindow();
            createWindow.Show();
        }

        private void MenuItem_Click_Close(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MenuItem_Click_OpenFile(object sender, RoutedEventArgs e)
        {
            string filename = Utilities.OpenXMLFile();

            if (filename != null)
            {
                DataSet caseDataSet = new DataSet();
                caseDataSet.ReadXml(filename);
                DataView caseDataView = new DataView(caseDataSet.Tables[0]);
                caseGrid.ItemsSource = caseDataView;
            }
            else MessageBox.Show(string.Format("The return value is {0}", filename));
        }
    }
}
