﻿using System;
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
using PhapY.uc;

namespace PhapY.TemplateControl
{
    /// <summary>
    /// Interaction logic for TemplateThongKeTuThi.xaml
    /// </summary>
    public partial class TemplateThongKeTuThi : UserControl
    {
        public TemplateThongKeTuThi()
        {
            InitializeComponent();
        }

        private void btnThongKeHoSo_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            var tkhs = new ThongKeTuThi();
            Container.Children.Add(tkhs);
        }

        private void btnChartHoSo_Click(object sender, RoutedEventArgs e)
        {
            Container.Children.Clear();
            var bdtkhs = new BieuDoThongKeTuThi();
            Container.Children.Add(bdtkhs);
        }
    }
}
