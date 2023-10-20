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

namespace _1020_localization
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string Language {  get; set; }  
        public MainWindow()
        {
            InitializeComponent();
            Language = "EN";
        }
        private void btnChangeLanguage_Click(object sender, RoutedEventArgs e)
        {
            if (Language == "EN")
            {
                ResourceDictionary newDictionary = new ResourceDictionary();
                newDictionary.Source = new Uri("Resources/DictionaryUA.xaml", UriKind.Relative);
                Application.Current.Resources.MergedDictionaries[0] = newDictionary;
                Language = "UA";
            }
            else if (Language == "UA")
            {
                ResourceDictionary newDictionary = new ResourceDictionary();
                newDictionary.Source = new Uri("Resources/DictionaryEN.xaml", UriKind.Relative);
                Application.Current.Resources.MergedDictionaries[0] = newDictionary;
                Language = "EN";
            }
        }
    }
}
