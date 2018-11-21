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
	public partial class CustomCell : ViewCell
	{
        //private Label nameLabel, timeLabel;
        //private Image image;

        //public static readonly BindableProperty NameProperty =
        //    BindableProperty.Create("CallName", typeof(string), typeof(CustomCell), "CallName");
        //public static readonly BindableProperty TimeProperty =
        //    BindableProperty.Create("CallTime", typeof(string), typeof(CustomCell), "CallTime");
        //public static readonly BindableProperty ImageProperty =
        //    BindableProperty.Create("ImageSource", typeof(Image), typeof(CustomCell), "ImageSource");

        //public string CallName
        //{
        //    get { return (string)GetValue(NameProperty); }
        //    set { SetValue(NameProperty, value); }
        //}

        //public string CallTime
        //{
        //    get { return (string)GetValue(TimeProperty); }
        //    set { SetValue(TimeProperty, value); }
        //}

        //public string ImageSource
        //{
        //    get { return (string)GetValue(ImageProperty); }
        //    set { SetValue(ImageProperty, value); }
        //}


        public CustomCell ()
		{
			InitializeComponent ();
		}

        //protected override void OnBindingContextChanged()
        //{
        //    base.OnBindingContextChanged();

        //    if (BindingContext != null)
        //    {
        //        nameLabel.Text = CallName;
        //        timeLabel.Text = CallTime;
        //        image.Source = ImageSource;
        //    }
        //}
    }
}