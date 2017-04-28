using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modulo1.Modelo;
using System.Collections.ObjectModel;
using System.Threading.Tasks;


namespace Modulo1.Dal
{
    public class GarcomDAL
    {
        private ObservableCollection<Garcom> Garcons = new ObservableCollection<Garcom>();
        private static GarcomDAL GarcomInstance = new GarcomDAL();

        private GarcomDAL()
        {
            Garcons.Add(new Garcom()
            {
                Id = 1,
                Nome = "Brauzio",

            });

            Garcons.Add(new Garcom()
            {
                Id = 2,
                Nome = "Entencius",

            });

            Garcons.Add(new Garcom()
            {
                Id = 3,
                Nome = "Cartucious",

            });

            Garcons.Add(new Garcom()
            {
                Id = 4,
                Nome = "Adoliterio",

            });

            Garcons.Add(new Garcom()
            {
                Id = 5,
                Nome = "Castrogildo",

            });

            Garcons.Add(new Garcom()
            {
                Id = 6,
                Nome = "Asdrugio",

            });

            Garcons.Add(new Garcom()
            {
                Id = 7,
                Nome = "Gesfredio",

            });

            Garcons.Add(new Garcom()
            {
                Id = 8,
                Nome = "Gesfrundio",

            });

            Garcons.Add(new Garcom()
            {
                Id = 9,
                Nome = "Kentencio",

            });

            Garcons.Add(new Garcom()
            {
                Id = 10,
                Nome = "Gesifrelio",

            });
        }

        public static GarcomDAL GetInstance()
        {
            return GarcomInstance;
        }

        public ObservableCollection<Garcom> GetAll()
        {
            return Garcons;
        }

        public void Add(Garcom garcom)
        {
            this.Garcons.Add(garcom);
        }
        public void Remove(Garcom garcom)
        {
            this.Garcons.Remove(garcom);
        }
        public void Update(Garcom garcom)
        {
            this.Garcons[this.Garcons.IndexOf(garcom)] = garcom;
        }
    }
}


