using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Nevron.Nov.Data;
using Nevron.Nov.Grid;
using Nevron.Nov.Windows;

namespace NovWpfGridTestApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Set window size
            this.Width = 800;
            this.Height = 500;

            // Create NOV content
            NNovWidgetHost<NTableGridView> novContent = new NNovWidgetHost<NTableGridView>();
            Content = novContent;

            // Load data
            LoadData(novContent.Widget);
        }

        private void LoadData(NTableGridView gridView)
        {
            NTableGrid tableGrid = gridView.Grid;
            tableGrid.DataSource = CreateDummyDataSource();
            tableGrid.AlternatingRows = true;
            tableGrid.AllowEdit = true;
        }

        /// <summary>
        /// Creates the data source to bind the grid to.
        /// </summary>
        public static NDataSource CreateDummyDataSource()
        {
            NMemoryDataTable dataTable = new NMemoryDataTable(new NFieldInfo[]{
                new NFieldInfo("EmployeeID", typeof(Int32)),
                new NFieldInfo("Name", typeof(String)),
                new NFieldInfo("City", typeof(String)),
                new NFieldInfo("Birth Date", typeof(DateTime)),
                new NFieldInfo("Hire Date", typeof(DateTime)),
                new NFieldInfo("Married", typeof(Boolean))
            });

            dataTable.AddRow(1, "Nancy Davolio", "Seattle", new DateTime(1968, 12, 8), new DateTime(1992, 5, 1), true);
            dataTable.AddRow(2, "Andrew Fuller", "Tacoma", new DateTime(1952, 2, 19), new DateTime(1992, 8, 14), true);
            dataTable.AddRow(3, "Janet Leverling", "Kirkland", new DateTime(1963, 8, 30), new DateTime(1992, 4, 1), false);
            dataTable.AddRow(4, "Margaret Peacock", "Redmond", new DateTime(1958, 9, 19), new DateTime(1993, 5, 3), false);
            dataTable.AddRow(5, "Steven Buchanan", "London", new DateTime(1955, 3, 4), new DateTime(1993, 10, 17), true);
            dataTable.AddRow(6, "Michael Suyama", "London", new DateTime(1963, 7, 2), new DateTime(1993, 10, 17), true);
            dataTable.AddRow(7, "Robert King", "London", new DateTime(1960, 5, 29), new DateTime(1994, 1, 2), false);
            dataTable.AddRow(8, "Laura Callahan", "Seattle", new DateTime(1958, 1, 9), new DateTime(1994, 3, 5), true);
            dataTable.AddRow(9, "Anne Dodsworth", "London", new DateTime(1969, 7, 2), new DateTime(1994, 11, 15), false);

            return new NDataSource(dataTable);
        }
    }
}
