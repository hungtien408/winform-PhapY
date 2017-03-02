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
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;
using PhapY.App_Code;

namespace PhapY
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        string connectionString = Common.ConnectionString;
        public Window1()
        {
            InitializeComponent();
            DataView dv= get_RichTextBox();
            if (dv.Count != 0)
            {
                byte[] b = (byte[])dv[0]["content"];
                var ms = new MemoryStream(b);
                richTextBox1.Selection.Load(ms, DataFormats.Rtf);
                richTextBox2.Document.Blocks.Clear();
                richTextBox2.Selection.Load(ms, DataFormats.Rtf);
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TextRange textRange = new TextRange(richTextBox1.Document.ContentStart, richTextBox1.Document.ContentEnd);
            var ms = new MemoryStream();
            textRange.Save(ms, DataFormats.Rtf);
            //richTextBox1.Selection.Save(ms, DataFormats.Rtf);
            byte[] b = ms.GetBuffer();
            string s = Encoding.UTF8.GetString(b);

            string newLine = @"{\f0 {\ltrch }\li0\ri0\sa0\sb0\fi0\ql\sl300\slmult0\par}";
            s = s.Replace(newLine, "");
            textBox1.Text = s;
            b = Encoding.UTF8.GetBytes(s);
           // MessageBox.Show(newLine);
            insert_RichTextBox(b);
        }
        public void insert_RichTextBox(byte[] content)
        {
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("insert_RichTextBox", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@content", content);
            scon.Open();
            cmd.ExecuteNonQuery();
            scon.Close();
        }
        public DataView get_RichTextBox()
        {
            DataTable dt = new DataTable();
            SqlConnection scon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("get_RichTextBox", scon);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            return dt.DefaultView;
        }
    }
}
