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
using System.Printing;
using System.Windows.Markup;
using PhapY.uc;

namespace PhapY.SubWindows
{
    /// <summary>
    /// Interaction logic for WindowInBanGiamDinhTuThi.xaml
    /// </summary>
    public partial class WindowInBanGiamDinhTuThi : Window
    {
        string _MaHoSo;
        double height = 0, height1 = 0;
        InBanGiamDinhPhapYTuThi controlToPrint;
        InBanGiamDinhPhapYTuThiKhamNgoai controlToPrint1;
        public WindowInBanGiamDinhTuThi()
        {
            InitializeComponent();
        }
        public WindowInBanGiamDinhTuThi(string MaHoSo)
        {
            InitializeComponent();
            _MaHoSo = MaHoSo;
            int[] x = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            cbbCatBot.ItemsSource = x;
            controlToPrint = new InBanGiamDinhPhapYTuThi(MaHoSo);
            controlToPrint1 = new InBanGiamDinhPhapYTuThiKhamNgoai(MaHoSo);
            var sc = new ScrollViewer();
            sc.Loaded += new RoutedEventHandler(sc_Loaded);
            sc.Content = controlToPrint;
            Container.Children.Add(sc);

            var sc1 = new ScrollViewer();
            sc1.Loaded += new RoutedEventHandler(sc1_Loaded);
            sc1.Content = controlToPrint1;
            Container1.Children.Add(sc1);
        }
        void LoadData(string Ngay, string Thang, string Nam)
        {
            PrintDialog pd;
            FixedDocument fixdocument;

            height = controlToPrint.DesiredSize.Height;
            
            controlToPrint = new InBanGiamDinhPhapYTuThi(_MaHoSo);
            controlToPrint.Ngay = Ngay;
            controlToPrint.Thang = Thang;
            controlToPrint.Nam = Nam;
            if (chkCCGD.IsChecked.Value)
            {
                controlToPrint.lblGiamDoc.Visibility = Visibility.Collapsed;
                controlToPrint.lblGiamDinhVien.Content = "GIÁM ĐỐC";
            }
            pd = new PrintDialog();
            fixdocument = GetFixedDocument(controlToPrint, pd);
            documentViewer1.Document = fixdocument;

            height1 = controlToPrint1.DesiredSize.Height;
            controlToPrint1 = new InBanGiamDinhPhapYTuThiKhamNgoai(_MaHoSo);
            controlToPrint1.Ngay = Ngay;
            controlToPrint1.Thang = Thang;
            controlToPrint1.Nam = Nam;
            if (chkCCGD.IsChecked.Value)
            {
                controlToPrint1.lblGiamDoc.Visibility = Visibility.Collapsed;
                controlToPrint1.lblGiamDinhVien.Content = "GIÁM ĐỐC";
            }
            pd = new PrintDialog();
            fixdocument = GetFixedDocument(controlToPrint1, pd);
            documentViewer2.Document = fixdocument;
        }
        void sc_Loaded(object sender, RoutedEventArgs e)
        {
            height = controlToPrint.DesiredSize.Height;
            controlToPrint = new InBanGiamDinhPhapYTuThi(_MaHoSo);
            PrintDialog pd = new PrintDialog();
            var fixdocument = GetFixedDocument(controlToPrint, pd);
            documentViewer1.Document = fixdocument;
        }
        void sc1_Loaded(object sender, RoutedEventArgs e)
        {
            height1 = controlToPrint1.DesiredSize.Height;
            controlToPrint1 = new InBanGiamDinhPhapYTuThiKhamNgoai(_MaHoSo);
            PrintDialog pd = new PrintDialog();
            var fixdocument = GetFixedDocument1(controlToPrint1, pd);
            documentViewer2.Document = fixdocument;
        }
        private FixedDocument GetFixedDocument(FrameworkElement toPrint, PrintDialog printDialog)
        {
            //int OffsetCut = 880;
            //OffsetCut = OffsetCut - (20 * Int32.Parse(cbbCatBot.SelectedValue.ToString()));
            int OffsetCut = 900;
            OffsetCut = OffsetCut - (25 * Int32.Parse(cbbCatBot.SelectedValue.ToString()));
            PrintCapabilities capabilities = printDialog.PrintQueue.GetPrintCapabilities(printDialog.PrintTicket);
            Size pageSize = new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
            Size visibleSize = new Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);
            FixedDocument fixedDoc = new FixedDocument();
            //If the toPrint visual is not displayed on screen we neeed to measure and arrange it  
            toPrint.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            toPrint.Arrange(new Rect(new Point(0, 0), toPrint.DesiredSize));
            //  
            Size size = toPrint.DesiredSize;
            //Will assume for simplicity the control fits horizontally on the page  
            double yOffset = 0;
            int pageCounter = 0;
            while (yOffset < height)
            {
                pageCounter++;
                VisualBrush vb = new VisualBrush(toPrint);
                vb.Stretch = Stretch.None;
                vb.AlignmentX = AlignmentX.Left;
                vb.AlignmentY = AlignmentY.Top;
                vb.ViewboxUnits = BrushMappingMode.Absolute;
                vb.TileMode = TileMode.None;
                vb.Viewbox = new Rect(0, yOffset, visibleSize.Width, OffsetCut);
                PageContent pageContent = new PageContent();
                FixedPage page = new FixedPage();
                Label lblPageNumber = new Label();
                lblPageNumber.Content = "Page " + pageCounter;
                lblPageNumber.Margin = new Thickness(visibleSize.Width - 25, visibleSize.Height - 10, 0, 0);

                ((IAddChild)pageContent).AddChild(page);
                fixedDoc.Pages.Add(pageContent);
                page.Width = pageSize.Width;
                page.Height = pageSize.Height;
                Canvas canvas = new Canvas();

                //FixedPage.SetLeft(canvas, 96 * 0.75 + 30); // left margin
                FixedPage.SetLeft(canvas, 95 * 0.75 + 30); // left margin
                FixedPage.SetTop(canvas, 96 * 0.75 + 20); // top margin
                //FixedPage.SetBottom(canvas, 96 * 0.75); // top margin

                canvas.Width = visibleSize.Width;
                canvas.Height = OffsetCut;
                canvas.Background = vb;
                page.Children.Add(canvas);
                page.Children.Add(lblPageNumber);
                yOffset += OffsetCut;
            }
            return fixedDoc;
        }
        private FixedDocument GetFixedDocument1(FrameworkElement toPrint, PrintDialog printDialog)
        {
            //int OffsetCut = 880;
            //OffsetCut = OffsetCut - (20 * Int32.Parse(cbbCatBot.SelectedValue.ToString()));
            int OffsetCut = 900;
            OffsetCut = OffsetCut - (25 * Int32.Parse(cbbCatBot.SelectedValue.ToString()));
            PrintCapabilities capabilities = printDialog.PrintQueue.GetPrintCapabilities(printDialog.PrintTicket);
            Size pageSize = new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
            Size visibleSize = new Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);
            FixedDocument fixedDoc = new FixedDocument();
            //If the toPrint visual is not displayed on screen we neeed to measure and arrange it  
            toPrint.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
            toPrint.Arrange(new Rect(new Point(0, 0), toPrint.DesiredSize));
            //  
            Size size = toPrint.DesiredSize;
            //Will assume for simplicity the control fits horizontally on the page  
            double yOffset = 0;
            int pageCounter = 0;
            while (yOffset < height1)
            {
                pageCounter++;
                VisualBrush vb = new VisualBrush(toPrint);
                vb.Stretch = Stretch.None;
                vb.AlignmentX = AlignmentX.Left;
                vb.AlignmentY = AlignmentY.Top;
                vb.ViewboxUnits = BrushMappingMode.Absolute;
                vb.TileMode = TileMode.None;
                vb.Viewbox = new Rect(0, yOffset, visibleSize.Width, OffsetCut);
                PageContent pageContent = new PageContent();
                FixedPage page = new FixedPage();
                Label lblPageNumber = new Label();
                lblPageNumber.Content = "Page " + pageCounter;
                lblPageNumber.Margin = new Thickness(visibleSize.Width - 25, visibleSize.Height - 10, 0, 0);

                ((IAddChild)pageContent).AddChild(page);
                fixedDoc.Pages.Add(pageContent);
                page.Width = pageSize.Width;
                page.Height = pageSize.Height;
                Canvas canvas = new Canvas();

                //FixedPage.SetLeft(canvas, 96 * 0.75 + 30); // left margin
                FixedPage.SetLeft(canvas, 95 * 0.75 + 30); // left margin
                FixedPage.SetTop(canvas, 96 * 0.75 + 20); // top margin
                //FixedPage.SetBottom(canvas, 96 * 0.75); // top margin

                canvas.Width = visibleSize.Width;
                canvas.Height = OffsetCut;
                canvas.Background = vb;
                page.Children.Add(canvas);
                page.Children.Add(lblPageNumber);
                yOffset += OffsetCut;
            }
            return fixedDoc;
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            string Ngay = dpNgayThangNam.SelectedDate != null ? string.Format("{0:dd}", dpNgayThangNam.SelectedDate.Value) : "";
            string Thang = dpNgayThangNam.SelectedDate != null ? string.Format("{0:MM}", dpNgayThangNam.SelectedDate.Value) : "";
            string Nam = dpNgayThangNam.SelectedDate != null ? string.Format("{0:yyyy}", dpNgayThangNam.SelectedDate.Value) : "";
            LoadData(Ngay, Thang, Nam);
        }

        private void chkCCGD_Click(object sender, RoutedEventArgs e)
        {
            string Ngay = dpNgayThangNam.SelectedDate != null ? string.Format("{0:dd}", dpNgayThangNam.SelectedDate.Value) : "";
            string Thang = dpNgayThangNam.SelectedDate != null ? string.Format("{0:MM}", dpNgayThangNam.SelectedDate.Value) : "";
            string Nam = dpNgayThangNam.SelectedDate != null ? string.Format("{0:yyyy}", dpNgayThangNam.SelectedDate.Value) : "";
            LoadData(Ngay, Thang, Nam);
        }

        //public static FixedDocument GetFixedDocument(FrameworkElement toPrint, PrintDialog printDialog)
        //{
        //    PrintCapabilities capabilities = printDialog.PrintQueue.GetPrintCapabilities(printDialog.PrintTicket);
        //    Size pageSize = new Size(printDialog.PrintableAreaWidth, printDialog.PrintableAreaHeight);
        //    Size visibleSize = new Size(capabilities.PageImageableArea.ExtentWidth, capabilities.PageImageableArea.ExtentHeight);
        //    FixedDocument fixedDoc = new FixedDocument();
        //    //If the toPrint visual is not displayed on screen we neeed to measure and arrange it  
        //    toPrint.Measure(new Size(double.PositiveInfinity, double.PositiveInfinity));
        //    toPrint.Arrange(new Rect(new Point(0, 0), toPrint.DesiredSize));
        //    //  
        //    Size size = toPrint.DesiredSize;
        //    //Will assume for simplicity the control fits horizontally on the page  
        //    double yOffset = 0;
        //    while (yOffset < size.Height)
        //    {
        //        VisualBrush vb = new VisualBrush(toPrint);
        //        vb.Stretch = Stretch.None;
        //        vb.AlignmentX = AlignmentX.Left;
        //        vb.AlignmentY = AlignmentY.Top;
        //        vb.ViewboxUnits = BrushMappingMode.Absolute;
        //        vb.TileMode = TileMode.None;
        //        vb.Viewbox = new Rect(0, yOffset, visibleSize.Width, visibleSize.Height);
        //        PageContent pageContent = new PageContent();
        //        FixedPage page = new FixedPage();

        //        ((IAddChild)pageContent).AddChild(page);
        //        fixedDoc.Pages.Add(pageContent);
        //        page.Width = pageSize.Width;
        //        page.Height = pageSize.Height;
        //        Canvas canvas = new Canvas();
        //        //FixedPage.SetLeft(canvas, capabilities.PageImageableArea.OriginWidth);
        //        //FixedPage.SetTop(canvas, capabilities.PageImageableArea.OriginHeight);

        //        FixedPage.SetLeft(canvas, 96 * 0.75); // left margin
        //        FixedPage.SetTop(canvas, 96 * 0.75); // top margin
        //        //FixedPage.SetBottom(canvas, 96 * 0.75); // top margin

        //        canvas.Width = visibleSize.Width;
        //        canvas.Height = visibleSize.Height - (96 * 0.75) * 2;
        //        canvas.Background = vb;
        //        page.Children.Add(canvas);
        //        yOffset += visibleSize.Height - (96 * 0.75) * 2;
        //    }
        //    return fixedDoc;
        //}  
    }
}
