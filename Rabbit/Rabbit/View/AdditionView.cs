using Rabbit.Controller;
using Xamarin.Forms;

namespace Rabbit.View
{
    public class AdditionView
    {
        #region Properties
        protected App Program { get; set; }
        protected MainController Controller { get; set; }
        protected MainView Parent { get; set; }
        protected Entry EntryName { get; set; }
        #endregion

        #region Constructor
        public AdditionView(App program, MainView parent)
        {
            Program = program;
            Parent = parent;
            Controller = parent.C;
            program.SetMainPage(GeneratePage());
        }
        #endregion

        #region Methods
        public Page GeneratePage()
        {
            Button buttonAdd = new Button();

            // Creating entry for name
            EntryName = new Entry();
            EntryName.HorizontalOptions = LayoutOptions.FillAndExpand;
            EntryName.HorizontalTextAlignment = TextAlignment.Start;

            // Creating button
            buttonAdd.Text = "Add habit";
            buttonAdd.Clicked += (o, s) => CreateHabit();

            // Creating page
            return new ContentPage
            {
                Title = "Add habit",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Start,
                    Children =
                    {
                        new StackLayout
                        {
                            Orientation = StackOrientation.Horizontal,
                            HorizontalOptions = LayoutOptions.FillAndExpand,
                            Children =
                            {
                                new Label
                                {
                                    Text = "Name: "
                                },
                                EntryName
                            }
                        },
                        buttonAdd
                    }
                }
            };
        }

        protected void CreateHabit()
        {
            // TODO Add habit to memory
            // TODO Extract information
            // TODO Call the controller to store the information
            // Returning to the main page
            Program.SetMainPage(Parent.GetMainPage());
        }
        #endregion
    }
}
