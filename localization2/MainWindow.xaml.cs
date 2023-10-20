using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace localization2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        string Language = "EN";
        private void UpdateUI()
        {
            MainWin.Title = lang.winTitle;
            labelName.Content = lang.labelName;
            labelPhone.Content = lang.labelPhone;
            labelSurname.Content = lang.labelSurname;
            btnCancel.Content = lang.btnCancel;
            btnChangeLanguage.Content = lang.btnChangeLanguage;
            btnOK.Content = lang.btnOK;
        }
        private void btnChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            if(Language == "EN")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("uk");
                UpdateUI();
                Language = "UK";
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("en");
                UpdateUI();
                Language = "EN";
            }
        }
    }
}
