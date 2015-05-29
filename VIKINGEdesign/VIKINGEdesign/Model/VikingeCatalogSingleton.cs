using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VIKINGEdesign.Persistency;

namespace VIKINGEdesign.Model
{
    class VikingeCatalogSingleton
    {
        /// <summary>
        /// Laver en instance af singleton.
        /// </summary>
        private static VikingeCatalogSingleton _instance = new VikingeCatalogSingleton();

        /// <summary>
        /// Under søger om der en en instance af singleton hvis der ikke er laver den en.
        /// </summary>
        public static VikingeCatalogSingleton Instance
        {
            get { return _instance; }
        }

        /// <summary>
        /// Navn giver en instance af classen ObservableCollection Events og laver den public.
        /// </summary>
        public ObservableCollection<Kunde> Kunder { get; set; }
        public ObservableCollection<Billet> Billeter { get; set; }
        public ObservableCollection<Priser> Priser { get; set; }
        public ObservableCollection<Vikingeskibe> VikingeSkib { get; set; }

        /// <summary>
        /// Udfylder Events med data.
        /// </summary>
        private VikingeCatalogSingleton()
        {
            Kunder = new ObservableCollection<Kunde>();
            LoadKunderAsync();
            Billeter = new ObservableCollection<Billet>();
            LoadBilleterAsync();
            Priser = new ObservableCollection<Priser>();
            LoadPriserAsync();
            VikingeSkib = new ObservableCollection<Vikingeskibe>();
            LoadSkibeAsync();

        }

     
        /// <summary>
        /// Loader data fra databasen
        /// </summary>
        public async void LoadKunderAsync()
        {
            var kunder = await PersistencyService.LoadKunderFromJsonAsync();
            if (kunder != null)
                foreach (var k in Kunder)
                {
                    Kunder.Add(k);
                }
            else
            {
                //Data til testformål
                Kunder.Add(new Kunde("Email1","Navn1","12345678"));
                Kunder.Add(new Kunde("Email2","Navn2","12345678"));
            }
        }
        public async void LoadBilleterAsync()
        {
            var billeter = await PersistencyService.LoadBilleterFromJsonAsync();
            if (billeter != null)
                foreach (var b in Billeter)
                {
                    Billeter.Add(b);
                }
            else
            {
                //Data til testformål
                Billeter.Add(new Billet(1,123456789,123456789,123456789,new DateTime(2015,05,14), 1234,false));
                Billeter.Add(new Billet(2,123456789,123456789,123456789,new DateTime(2015,05,14), 1234,false));
            }
        }
        public async void LoadPriserAsync()
        {
            var priser = await PersistencyService.LoadPriserFromJsonAsync();
            if (priser != null)
                foreach (var p in priser)
                {
                    Priser.Add(p);
                }
            else
            {
                //Data til testformål
                Priser.Add(new Priser(1, 1234, "1"));
                Priser.Add(new Priser(2, 1234, "2"));
            }
        }

        public async void LoadSkibeAsync() {
            var skibe = await PersistencyService.LoadSkibeFromJsonAsync();
            if (skibe != null)
                foreach (var s in skibe) {
                    VikingeSkib.Add(s);
                }
            else {
                //Data til testformål
            VikingeSkib.Add(new Vikingeskibe(1, "lotte", 33, "lottddse", "hje", "hej"));

            }
        }

        /// <summary>
        /// Gemmer data i databasen.
        /// </summary>
        /// <param name="billetId"></param>
        /// <param name="kundeId"></param>
        /// <param name="antalBorn"></param>
        /// <param name="antalStuderende"></param>
        /// <param name="antalVoksne"></param>
        /// <param name="dateTime"></param>
        /// <param name="pris"></param>
        /// <param name="sejltur"></param>
        public void Add(int antalBorn, int antalStuderende, int antalVoksne, DateTime dateTime, decimal pris, bool sejltur, string email, string navn, string telefonNr)
        {
            Kunde newKunde = new Kunde(email, navn, telefonNr);
            Kunder.Add(newKunde);
            PersistencyService.SaveKunderAsJsonAsync(newKunde);
            Billet newBillet = new Billet(PersistencyService.ID,antalBorn, antalStuderende, antalVoksne, new DateTime(dateTime.Year,dateTime.Month,dateTime.Day), pris, sejltur);
            Billeter.Add(newBillet);
            PersistencyService.SaveBilleterAsJsonAsync(newBillet);
        }
    }
}
