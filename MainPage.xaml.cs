using System.Collections.ObjectModel;

namespace Mlab2_Piñera
{
    
    public partial class MainPage : ContentPage
    {
        private ObservableCollection<string> Items { get; set; } = new ObservableCollection<string>();

        public MainPage()
        {
            InitializeComponent();
            ItemsListView.ItemsSource = Items;
        }
        private void OnAddButtonClicked(object sender, EventArgs e)
        {
            Items.Add(ItemEntry.Text);
            ItemEntry.Text = string.Empty;
        }



    }

    

}
