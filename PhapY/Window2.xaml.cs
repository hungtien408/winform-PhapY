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
using System.Windows.Forms;
using System.Windows.Xps.Packaging;
using System.IO;
using System.Windows.Markup;
using System.Windows.Xps.Serialization;
using System.IO.Packaging;
using System.Reflection;

namespace PhapY
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        MemoryStream ms;
        Package pkg;
        XpsDocument doc;
        public Window2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            //OpenFileDialog o = new OpenFileDialog();
            //if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    XpsDocument doc = new XpsDocument(o.FileName, FileAccess.Read);
            //    documentViewer1.Document = doc.GetFixedDocumentSequence();
            //}
            Assembly asm = Assembly.GetExecutingAssembly();

            using (Stream io = asm.GetManifestResourceStream("Window2.xaml"))
            {
                IDocumentPaginatorSource text = XamlReader.Load(io) as IDocumentPaginatorSource;
                io.Close();

                ms = new MemoryStream();
                pkg = Package.Open(ms, FileMode.Create, FileAccess.ReadWrite);

                doc = new XpsDocument(pkg, CompressionOption.SuperFast);
                XpsSerializationManager rsm = new XpsSerializationManager(new XpsPackagingPolicy(doc), false);
                DocumentPaginator pgn = text.DocumentPaginator;
                rsm.SaveAsXaml(pgn);
                //documentViewer1.Document = doc.GetFixedDocumentSequence();
            }
            
        }
    }
}
