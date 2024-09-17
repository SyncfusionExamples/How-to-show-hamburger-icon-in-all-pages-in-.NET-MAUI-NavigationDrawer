namespace Navigation {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();
            List<string> list = new List<string>();
            list.Add("Home");
            list.Add("Profile");
            listView.ItemsSource = list;
        }

        void Handle_Clicked(object sender, System.EventArgs e) {
            navigationDrawer.ToggleDrawer();
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e) 
        {
            if (e.SelectedItem.ToString() == "Home")
                navigationDrawer.ContentView = new HomePage().Content;
            else if (e.SelectedItem.ToString() == "Profile")
                navigationDrawer.ContentView = new ProfilePage().Content;
            navigationDrawer.ToggleDrawer();
        }
    }

}
