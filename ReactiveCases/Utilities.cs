using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ReactiveCases
{
    static class Utilities
    {


        /// <summary>
        /// To open a XML file from Open File Dialoge.
        /// </summary>
        /// <returns></returns>
        public static string OpenXMLFile()
        {
            string filename = null;

            // Configure open file dialog box
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.FileName = "Document"; // Default file name
            dlg.DefaultExt = ".xml"; // Default file extension
            dlg.Filter = "XML documents (.xml)|*.xml"; // Filter files by extension

            // Show open file dialog box
            Nullable<bool> result = dlg.ShowDialog();

            // Process open file dialog box results
            if (result == true)
            {
                // Open document
                filename = dlg.FileName;
            }
            return filename;
        }


    }
}
