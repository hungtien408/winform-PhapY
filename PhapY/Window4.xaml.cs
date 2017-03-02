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
using System.Windows.Shapes;
using System.Windows.Markup;
using PhapY.uc;

namespace PhapY
{
    /// <summary>
    /// Interaction logic for Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }

        private void documentViewer1_Loaded(object sender, RoutedEventArgs e)
        {
            //Container.Children.Remove(uiPage1);
            //var content = new PageContent();
            //((IAddChild)content).AddChild(uiPage1);
            //uiReport.Pages.Add(content);

            //Set up the WPF Control to be printed
            var controlToPrint = new InBanGiamDinhPhapYThuongTat("320","aaa");
            var fixedDoc = new FixedDocument();
            var pageContent = new PageContent();
            var fixedPage = new FixedPage();

            //Create first page of document
            fixedPage.Children.Add(controlToPrint);
            ((IAddChild)pageContent).AddChild(fixedPage);
            fixedDoc.Pages.Add(pageContent);
            //Create any other required pages here

            //View the document
            documentViewer1.Document = fixedDoc;
        }
    }
}
