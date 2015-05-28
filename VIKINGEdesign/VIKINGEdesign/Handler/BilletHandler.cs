using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Popups;
using VIKINGEdesign.Converter;
using VIKINGEdesign.ViewModel;

namespace VIKINGEdesign.Handler
{
    class BilletHandler
    {
        public MainViewModel MainViewModel { get; set; }
        public PrisHandler PrisHandler { get; set; }

        public BilletHandler(MainViewModel mainViewModel, PrisHandler prisHandler)
        {
            MainViewModel = mainViewModel;
            PrisHandler = prisHandler;
        }

        public void CreateBillet()
        {
            PrisHandler.TotalPris();
            //if (MainViewModel.Navn.Length == 0)
            //{
            //    MessageDialog dialog = new MessageDialog("");
            //    dialog.ShowAsync();
            //}
            if (MainViewModel.Navn != "" || MainViewModel.Email != "" || MainViewModel.TelefonNr != "" ||
                (MainViewModel.AntalBorn + MainViewModel.AntalStuderende + MainViewModel.AntalVoksne) >= 1)
            {
                if (DateTimeConverter.DateTimeOffset(MainViewModel.DateTime) < DateTime.Today)
                {
                    MessageDialog dialog = new MessageDialog("Datoen på billet skal være idag eller senere.");
                }
                if (MainViewModel.Navn.Length <= 2)
                {
                    MessageDialog dialog = new MessageDialog("Navn skal udfyldes med mere end 2 bogstaver");
                }
                if (MainViewModel.TelefonNr.Contains(@"(^?!*\+45\d{8}$)|(^?!*\d{8}$)"))
                {
                    MessageDialog dialog = new MessageDialog("Telefon nummeret er ikke gyldigt");
                }
                if (MainViewModel.Email.Contains(@"^?!*(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$"))
                {
                    MessageDialog dialog = new MessageDialog("Emailen er ikke gyldig");
                }
                else
                {
                    MainViewModel.VikingeCatalogSingleton.Add(MainViewModel.AntalBorn, MainViewModel.AntalStuderende, MainViewModel.AntalVoksne, DateTimeConverter.DateTimeOffset(MainViewModel.DateTime), MainViewModel.Pris, MainViewModel.Sejltur, MainViewModel.Email, MainViewModel.Navn, MainViewModel.TelefonNr);
                }
            }
            else
            {
                MessageDialog dialog = new MessageDialog("Alle felter skal udfyldes.");
            }
        }
    }
}
