using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Projet.Model
{

    public class JobsModel
    {


        
        public ObservableCollection<Items> Items { get; set; }

        public ObservableCollection<Items> CartItems { get; set; }

        public Items SelectedItem { get; set; }

        public ICommand Itemclick { get; set; }


        public JobsModel()
        {
            Items = new ObservableCollection<Items>
            {
                new Items
                {
                    Name = "Nom du métier",
                    Description = "Ce métier est destiné aux personnes",
                    Info = "Pour postuler, veuiller contacter"
                },
                new Items
                {
                    Name = "Nom du métier",
                    Description = "Ce métier est destiné aux personnes",
                    Info = "Pour postuler, veuiller contacter"
                },
                new Items
                {
                    Name = "Nom du métier",
                    Description = "Ce métier est destiné aux personnes",
                    Info = "Pour postuler, veuiller contacter"
                },
                new Items
                {
                    Name = "Nom du métier",
                    Description = "Ce métier est destiné aux personnes",
                    Info = "Pour postuler, veuiller contacter"
                },
                new Items
                {
                    Name = "Nom du métier",
                    Description = "Ce métier est destiné aux personnes",
                    Info = "Pour postuler, veuiller contacter"
                },
                new Items
                {
                    Name = "Nom du métier",
                    Description = "Ce métier est destiné aux personnes",
                    Info = "Pour postuler, veuiller contacter"
                }
            };
        }
    }
}
