using Rabbit.Controller;
using Xamarin.Forms;

namespace Rabbit.View
{
    public class MainView
    {
        public Page GetMainPage()
        {
            TabbedPage tabs = new TabbedPage();

            // Setup tabbed page
            tabs.Children.Add(GenerateTestPage("page 1!"));
            tabs.Children.Add(GenerateTestPage("page 2?"));

            return tabs;
        }

        public ContentPage GenerateTestPage(string message)
        {
            return new ContentPage
            {
                Title = message,
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = message
                        }
                    }
                }
            };
        }

        protected MainController _C_ { get; set; } = null;
        public MainController C
        {
            get
            {
                return _C_;
            }
            set
            {
                if (_C_ == null)
                {
                    _C_ = value;
                }
            }
        }
    }
}
