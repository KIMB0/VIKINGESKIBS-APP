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
            get { return _instance ?? (_instance = new VikingeCatalogSingleton()); }
        }

        /// <summary>
        /// Navn giver en instance af classen ObservableCollection Events og laver den public.
        /// </summary>
        public ObservableCollection<Kunde> Kunder { get; set; }
        public ObservableCollection<Billet> Billeter { get; set; }
        

        /// <summary>
        /// Udfylder Events med data.
        /// </summary>
        private VikingeCatalogSingleton()
        {
            Billeter = new ObservableCollection<Billet>();
            LoadBilleterAsync();
            Kunder = new ObservableCollection<Kunde>();
            LoadKunderAsync();
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
                Kunder.Add(new Kunde(1,"Email1","Navn1",12345678));
                Kunder.Add(new Kunde(2,"Email2","Navn2",12345678));
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
                Billeter.Add(new Billet(1,1,123456789,123456789,123456789,new DateTime(2015,05,14), 12.34,false));
                Billeter.Add(new Billet(2,2,123456789,123456789,123456789,new DateTime(2015,05,14), 12.34,false));
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
        public void AddBilleter(int billetId, int kundeId, int antalBorn, int antalStuderende, int antalVoksne, DateTime dateTime, double pris, bool sejltur)
        {
            Billet newBillet = new Billet(billetId,kundeId,antalBorn,antalStuderende,antalVoksne,dateTime,pris,sejltur);
            Billeter.Add(newBillet);
            PersistencyService.SaveBilleterAsJsonAsync(newBillet);
        }
        public void AddKunder(int kundeId, string email, string navn, int telefonNr)
        {
            Kunde newKunde = new Kunde(kundeId,email,navn,telefonNr);
            Kunder.Add(newKunde);
            PersistencyService.SaveKunderAsJsonAsync(newKunde);
        }
    }
}
