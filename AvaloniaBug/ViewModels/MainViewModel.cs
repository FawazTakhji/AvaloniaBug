using System.Collections.ObjectModel;
using AvaloniaBug.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace AvaloniaBug.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Category> _categories;

        [ObservableProperty]
        private Category _selectedItem;

        public MainViewModel()
        {
            Categories =
            [
                new Category("Item 0", "0_0"),
                new Category("Item 1", "1_0",
                [
                    new Category("SubItem 1", "Item 1 - SubItem 1", "1_1"),
                    new Category("SubItem 2", "Item 1 - SubItem 2", "1_2"),
                    new Category("SubItem 3", "Item 1 - SubItem 3", "1_3")
                ]),
                new Category("Item 2", "2_0",
                [
                    new Category("SubItem 1", "Item 2 - SubItem 1", "2_1"),
                    new Category("SubItem 2", "Item 2 - SubItem 2", "2_2"),
                    new Category("SubItem 3", "Item 2 - SubItem 3", "2_3")
                ])
            ];
        }

    }
}