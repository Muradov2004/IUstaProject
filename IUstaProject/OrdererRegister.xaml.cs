using Microsoft.Win32;
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

namespace IUstaProject
{
    /// <summary>
    /// Interaction logic for OrdererRegister.xaml
    /// </summary>
    public partial class OrdererRegister : Window
    {
        private string sourceFilePath;

        public OrdererRegister()
        {
            InitializeComponent();
        }

        public void EncryptFile()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dialog.InitialDirectory = @"C:\";
            dialog.Title = "Please select an image file to encrypt.";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                //Encrypt the selected file. I'll do this later. :)
            }
        }
        private void OpenFileDialog_Click(object sender, RoutedEventArgs e)
        {
            EncryptFile();
        }
    }
}
