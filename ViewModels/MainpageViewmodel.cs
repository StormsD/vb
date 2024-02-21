using OndernemingMVVM2.data.repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OndernemingMVVM2.ViewModels
{
    public partial class MainPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<Werknemer> werknemers;

        private Werknemerrepository _repo;

        public MainPageViewModel(Werknemerrepository repo)
        {
            _repo = repo;
        }
        [RelayCommand]
        private void ToonWerknemers()
        {
            Werknemers = new ObservableCollection<Werknemer>(_repo.GetWerknemers());
        }
    }
}