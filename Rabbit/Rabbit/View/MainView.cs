using Rabbit.Controller;
using Xamarin.Forms;

namespace Rabbit.View
{
    /// <summary>
    /// View class in a MVC perspective for the main vision the user will
    /// have of this application.
    /// </summary>
    public class MainView
    {
        #region Properties
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
        public App A { get; private set; } = null;
        #endregion

        #region Methods
        public MainView(App app)
        {
            A = app;
        }

        /// <summary>
        /// Generates the main page this view was made for.
        /// </summary>
        /// <returns></returns>
        public Page GetMainPage()
        {
            TabbedPage tabs = new TabbedPage();

            // Setup tabbed page
            tabs.Children.Add(GenerateHabitsPage());
            tabs.Children.Add(GenerateTestPage("page 2?"));

            return tabs;
        }

        /// <summary>
        /// Sets the main page of the current application.
        /// </summary>
        public void SetMainPage()
        {
            A.SetMainPage(GetMainPage());
        }

        /// <summary>
        /// Designs the habits page.
        /// </summary>
        public ContentPage GenerateHabitsPage()
        {
            ContentPage page = new ContentPage();
            StackLayout layout = new StackLayout();
            Button buttonAdd = new Button();
            string[] habits = C.GetHabits();

            // IDEA Maybe use another class for this task?

            // Working on the add button
            buttonAdd.Text = "Add habit";
            buttonAdd.Clicked += (o, s) => CreateHabit();

            // TODO Design this page
            layout.VerticalOptions = LayoutOptions.Start;
            layout.HorizontalOptions = LayoutOptions.FillAndExpand;
            if (habits.Length == 0)
            {
                layout.Children.Add(new Label
                {
                    FontSize = 20,
                    HorizontalTextAlignment = TextAlignment.Center,
                    Text = "Let's add habits?"
                });
            }
            else
            {
                // TODO Implement creation of habit divisions
            }
            layout.Children.Add(buttonAdd);

            // Populating page
            page.Title = "Habits";
            page.Content = layout;

            return page;
        }

        internal void CreateHabit()
        {
            // Start creation page
            AdditionView view = new AdditionView(A, this);
            
            // TODO Implement creation of habits
            C.CreateHabit();
        }

        // TODO Implement tracker page

        /// <summary>
        /// Creates a default page with a message.
        /// </summary>
        /// <param name="message">String to appear in the middle of the page.</param>
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
        #endregion
    }
}
