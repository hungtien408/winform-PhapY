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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Web;
using System.Text.RegularExpressions;

namespace PhapY.Controls
{
    /// <summary>
    /// Interaction logic for RichTextBox.xaml
    /// </summary>
    public partial class RichTextBox : UserControl
    {
        public static readonly DependencyProperty InfoTextProperty = DependencyProperty.Register(
            "Text",
            typeof(string),
            typeof(RichTextBox),
            new FrameworkPropertyMetadata(
                new PropertyChangedCallback(ChangeText)));

        public string Text
        {
            get
            {
                TextRange textRange = new TextRange(XAMLRichBox.Document.ContentStart, XAMLRichBox.Document.ContentEnd);
                return textRange.Text;
            }
            set
            {
                UpdateText(value);
            }
        }

        private static void ChangeText(DependencyObject source, DependencyPropertyChangedEventArgs e)
        {
            if (e.NewValue != null)
                ((RichTextBox)source).UpdateText(e.NewValue.ToString());
            else
                ((RichTextBox)source).UpdateText("");
        }

        private void UpdateText(string NewText)
        {
            FlowDocument mcFlowDoc = new FlowDocument();
            Paragraph para = new Paragraph();
            para.Inlines.Add(NewText);
            mcFlowDoc.Blocks.Add(para);
            XAMLRichBox.Document = mcFlowDoc;
        }

        public RichTextBox()
        {
            InitializeComponent();
            ContextMenu myMenu = new ContextMenu();
            MenuItem myItem;
            Separator sep;
            myItem = new MenuItem();
            myItem.Header = "Cut";
            myItem.Command = ApplicationCommands.Cut;
            myMenu.Items.Add(myItem);

            myItem = new MenuItem();
            myItem.Header = "Copy";
            myItem.Command = ApplicationCommands.Copy;
            myMenu.Items.Add(myItem);

            myItem = new MenuItem();
            myItem.Header = "Paste";
            myItem.Command = ApplicationCommands.Paste;
            myMenu.Items.Add(myItem);

            sep = new Separator();
            myMenu.Items.Add(sep);

            myItem = new MenuItem();
            myItem.Header = "Insert circular bullet";
            myItem.InputGestureText = "\u2022";
            myItem.Click += new RoutedEventHandler(InsertSquareBullet_Click);
            myMenu.Items.Add(myItem);

            myItem = new MenuItem();
            myItem.Header = "Insert square bullet";
            myItem.InputGestureText = "\u25AA";
            myItem.Click += new RoutedEventHandler(InsertCircularBullet_Click);
            myMenu.Items.Add(myItem);

            myItem = new MenuItem();
            myItem.Header = "Insert white bullet";
            myItem.InputGestureText = "\u25E6";
            myItem.Click += new RoutedEventHandler(InsertWhiteBullet_Click);
            myMenu.Items.Add(myItem);

            myItem = new MenuItem();
            myItem.Header = "Insert triangular bullet";
            myItem.InputGestureText = "\u25B8";
            myItem.Click += new RoutedEventHandler(InsertTriangularBullet_Click);
            myMenu.Items.Add(myItem);

            sep = new Separator();
            myMenu.Items.Add(sep);

            myItem = new MenuItem();
            myItem.Header = "Insert line number";
            myItem.InputGestureText = "1. 2. 3. ...";
            myItem.Click += new RoutedEventHandler(InsertLineNumber_Click);
            myMenu.Items.Add(myItem);

            XAMLRichBox.ContextMenu = myMenu;
        }

        void InsertSquareBullet_Click(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(XAMLRichBox.Selection.Start, XAMLRichBox.Selection.End);
            var text = tr.Text;
            text = "  \u2022  " + text.Replace(Environment.NewLine, Environment.NewLine + "  \u2022  ");
            tr.Text = text;
        }

        void InsertCircularBullet_Click(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(XAMLRichBox.Selection.Start, XAMLRichBox.Selection.End);
            var text = tr.Text;
            //text = "  \u25AA  " + text.Replace(Environment.NewLine, Environment.NewLine + "  \u25AA  ");
            text = "      \u25AA  " + text.Replace(Environment.NewLine, Environment.NewLine + "      \u25AA  ");
            tr.Text = text;
            //Paragraph para = new Paragraph();
            //para.Inlines.Add(text);
            //List l = new List();
            //l.MarkerStyle = TextMarkerStyle.Circle;
            //ListItem li = new ListItem(para);
            //l.ListItems.Add(li);
            //XAMLRichBox.Document.Blocks.Add(l);

        }
        void InsertWhiteBullet_Click(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(XAMLRichBox.Selection.Start, XAMLRichBox.Selection.End);
            var text = tr.Text;
            text = "          \u25E6  " + text.Replace(Environment.NewLine, Environment.NewLine + "          \u25E6  ");
            tr.Text = text;
        }
        void InsertTriangularBullet_Click(object sender, RoutedEventArgs e)
        {
            TextRange tr = new TextRange(XAMLRichBox.Selection.Start, XAMLRichBox.Selection.End);
            var text = tr.Text;
            text = "             \u25B8  " + text.Replace(Environment.NewLine, Environment.NewLine + "             \u25B8  ");
            tr.Text = text;
        }
        void InsertLineNumber_Click(object sender, RoutedEventArgs e)
        {

            TextPointer caretLineStart = XAMLRichBox.CaretPosition.GetLineStartPosition(0);
            TextPointer p = XAMLRichBox.Document.ContentStart.GetLineStartPosition(0);

            TextRange tr = new TextRange(XAMLRichBox.Document.ContentStart.GetLineStartPosition(0), XAMLRichBox.CaretPosition);
            TextRange tr1 = new TextRange(caretLineStart, XAMLRichBox.CaretPosition);

            var text = tr.Text;
            Regex regex;
            Match m;
            regex = new Regex(Environment.NewLine + @"(\s*)(?<num>\d+)(.)");
            m = regex.Match(text);
            string lineNum = "", textNum = "";
            while (m.Success)
            {
                Group g = m.Groups["num"];
                lineNum = g.Value;
                m = m.NextMatch();
            }
            if (string.IsNullOrEmpty(lineNum))
            {
                regex = new Regex(@"^(\s*)(?<num>\d+)(.)");
                m = regex.Match(text);
                if (m.Success)
                {
                    Group g = m.Groups["num"];
                    lineNum = g.Value;
                }
            }
            if (string.IsNullOrEmpty(lineNum))
            {
                textNum = "1. ";
                tr1.Text = textNum + tr1.Text;
            }
            else
            {
                textNum = (Int32.Parse(lineNum) + 1) + ". ";
                if (!tr1.Text.StartsWith(lineNum))
                {
                    tr1.Text = textNum + tr1.Text;
                }
            }
        }
        protected void BlockTheCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = false;
            e.Handled = true;
        }
        protected void InsertCurrentDate(object sender, EventArgs e)
        {
            TextRange tr = new TextRange(XAMLRichBox.Selection.Start, XAMLRichBox.Selection.End);
            tr.Text = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
        }
    }
}
