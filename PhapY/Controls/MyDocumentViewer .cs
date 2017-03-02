using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Controls;
using System.Printing;
using System.Windows.Documents;
using System.Windows.Xps;
using System.Windows.Annotations;
using System.Windows;
using System.Windows.Media;
using System.Globalization;

namespace PhapY.Controls
{
    public class MyDocumentViewer : DocumentViewer
    {
        protected override void OnPrintCommand()
        {
            //// get a print dialog, defaulted to default printer and default printer's preferences.
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.PrintQueue = LocalPrintServer.GetDefaultPrintQueue();
            ////printDialog.PrintTicket = dialog.PrintQueue.DefaultPrintTicket;
            //printDialog.UserPageRangeEnabled = true;
            //// get a reference to the FixedDocumentSequence for the viewer.
            //FixedDocumentSequence docSeq = this.Document as FixedDocumentSequence;

            //// set the default page orientation based on the desired output.
            ////printDialog.PrintTicket.PageOrientation = GetDesiredPageOrientation(docSeq);

            //if (printDialog.ShowDialog() == true)
            //{
            //    // set the print ticket for the document sequence and write it to the printer.
            //    docSeq.PrintTicket = printDialog.PrintTicket;

            //    XpsDocumentWriter writer = PrintQueue.CreateXpsDocumentWriter(printDialog.PrintQueue);
            //    writer.WriteAsync(docSeq, printDialog.PrintTicket);
            //}


            PrintDialog dialog = new PrintDialog();
            dialog.UserPageRangeEnabled = true;
            var paginator = this.Document.DocumentPaginator;

            bool? result = dialog.ShowDialog();
            if (result != null && result.Value)
            {
                if (dialog.PageRangeSelection == PageRangeSelection.UserPages)
                {
                    paginator = new PageRangeDocumentPaginator(paginator, dialog.PageRange);
                }
                dialog.PrintDocument(paginator, "Print");
            }
        }

    }

    public class PageRangeDocumentPaginator : DocumentPaginator
    {
        private int _startIndex;
        private int _endIndex;
        private DocumentPaginator _paginator;
        public PageRangeDocumentPaginator(
          DocumentPaginator paginator,
          PageRange pageRange)
        {
            _startIndex = pageRange.PageFrom - 1;
            _endIndex = pageRange.PageTo - 1;
            _paginator = paginator;

            // Adjust the _endIndex
            _endIndex = Math.Min(_endIndex, _paginator.PageCount - 1);
        }
        public override DocumentPage GetPage(int pageNumber)
        {
            // Just return the page from the original
            // paginator by using the "startIndex"
            return _paginator.GetPage(pageNumber + _startIndex);
        }

        public override bool IsPageCountValid
        {
            get { return true; }
        }

        public override int PageCount
        {
            get
            {
                if (_startIndex > _paginator.PageCount - 1)
                    return 0;
                if (_startIndex > _endIndex)
                    return 0;

                return _endIndex - _startIndex + 1;
            }
        }

        public override Size PageSize
        {
            get { return _paginator.PageSize; }
            set { _paginator.PageSize = value; }
        }

        public override IDocumentPaginatorSource Source
        {
            get { return _paginator.Source; }
        }
    }

}
