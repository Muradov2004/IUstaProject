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

namespace IUstaProject;

/// <summary>
/// Interaction logic for LoginWindow.xaml
/// </summary>
public partial class LoginWindow : Window
{
    List<Expert> experts = new List<Expert>();
    List<Orderer> orderers = new List<Orderer>();
    public LoginWindow()
    {
        InitializeComponent();
        experts = JsonClass.ReadJsonExpert();
        orderers = JsonClass.ReadJsonOrderer();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        if ((experts.Exists(a => a.Email == Email.Text) && (experts.Exists(a => a.Password == Pasword.Password))) || (orderers.Exists(a => a.Email == Email.Text) && (orderers.Exists(a => a.Password == Pasword.Password))) || (Email.Text == "admin" && Pasword.Password == "admin"))
        {
            if (Email.Text == "admin" && Pasword.Password == "admin")
            {
                var window = new AdminWindow();
                window.Show();
                Hide();
            }
        }
    }
}
