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

namespace apolowpf.UseControl
{
    /// <summary>
    /// Interaction logic for Item.xaml
    /// </summary>
    public partial class ItemNomal : UserControl
    {
        public ItemNomal()
        {
            InitializeComponent();
        }
        public string Status { get; set; }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            switch (Status)
            {
                case "30":
                    lbl_Status.Foreground = new SolidColorBrush(Color.FromRgb(220, 53, 69));
                    lbl_Status.Content = "30 phút nữa";
                    break;
                case "trahen":
                    lbl_Status.Content = "Khách trả hẹn";
                    break;
                case "danglam":
                    lbl_Status.Content = "Đang làm";
                    break;
                case "60":
                    lbl_Status.Content = "60 phút nữa";
                    break;
                default:
                    break;
            }
        }
    }
}
