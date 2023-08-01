using RetailApp.Utility;
using RetailApp.ViewModels;
using RetailApp.ViewModels.Fiscal;
using System.Windows;

namespace RetailApp.DesktopUI
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            ImportXML();
        }

        private void ImportXML()
        {
            string xmlContent = FileUtility.GetStringFromXml();
            nfeProc nfeProcObj = XmlUtility.XmlToClass<nfeProc>(xmlContent);
        }
       
    }
}
