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
using System.Xaml;
using System.Xml;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            XmlDocument doc = new XmlDocument();
            doc.Load(@"c:\obmen\меню.xml");

            XmlDataProvider providerpodr = (XmlDataProvider)FindResource("xmlMenu");
            providerpodr.Document = doc;
            providerpodr.Refresh();


            XmlDocument menu = new XmlDocument();
            menu.Load(@"c:\obmen\Подразделения.xml");

            XmlDataProvider provider = (XmlDataProvider)FindResource("xmlPodr");
            provider.Document = menu;
            provider.Refresh();
        }


    }


    
}
