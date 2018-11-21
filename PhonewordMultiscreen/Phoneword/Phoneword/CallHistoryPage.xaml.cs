using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Phoneword
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CallHistoryPage : ContentPage
    {
        public class CallDetail {
            public string CallName { get; set; }
            public string CallTime { get; set; }
            public string ImageSource { get; set; } 
        }
		public CallHistoryPage ()
		{
			InitializeComponent ();
            var customCell = new DataTemplate(typeof(CustomCell));
            //customCell.SetBinding(CustomCell.NameProperty, "CallName");
            //customCell.SetBinding(CustomCell.TimeProperty, "CallTime");
            //customCell.SetBinding(CustomCell.ImageProperty, "ImageSource");
            HistoryCalls.ItemTemplate = customCell;
            HistoryCalls.ItemsSource = App.callDetails;
        }
	}
}