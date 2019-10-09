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
using System.Net.Mail;
using System.Net;

namespace WpfApp3
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SmtpClient SMTP = new SmtpClient();
            SMTP.UseDefaultCredentials = false;

            ICredentialsByHost cred;
            
            SMTP.Credentials = ICredentialsByHost //("info@sos-food.com", "sosfood2019**escritorioseguro");
            SMTP.Port = 25
            SMTP.EnableSsl = False
            SMTP.Host = "mail.sos-food.com"
            SMTP.Send("info@sos-food.com", "enriqueheredia.e@gmail.com", "Hola", "un saludo makina.")
        }
    }
}
