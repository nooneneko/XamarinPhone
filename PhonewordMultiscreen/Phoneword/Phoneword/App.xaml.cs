using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Phoneword.CallHistoryPage;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Phoneword
{
	public partial class App : Application
	{
        public static ObservableCollection<CallDetail> callDetails; 
		public App ()
		{
			InitializeComponent();
            callDetails = new ObservableCollection<CallDetail>();
            MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
