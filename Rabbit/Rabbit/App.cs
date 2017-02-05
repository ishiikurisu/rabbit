using Rabbit.Model;
using Rabbit.View;
using Rabbit.Controller;
using Xamarin.Forms;

namespace Rabbit
{
	public class App : Application
	{
		public App ()
		{
            // MVC Setup
            MainModel model = new MainModel();
            MainView view = new MainView();
            MainController controller = new MainController(model, view);


            // The root page of your application
            MainPage = view.GetMainPage();
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
