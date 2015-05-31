using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            MessageDialog dialog = new MessageDialog("");
            Regex regexTelefonNr1 = new Regex(@"^\d{8}$");
            Regex regexTelefonNr2 = new Regex(@"^\+45\d{8}$");
            Regex regexEmail = new Regex(@"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$");
            PrisHandler.TotalPris();
            //if (MainViewModel.Navn.Length == 0)
            //{
            //    MessageDialog dialog = new MessageDialog("");
            //    dialog.ShowAsync();
            //}
            if (!string.IsNullOrEmpty(MainViewModel.Navn) && !string.IsNullOrEmpty(MainViewModel.Email) && !string.IsNullOrEmpty(MainViewModel.TelefonNr) &&
                (MainViewModel.AntalBorn + MainViewModel.AntalStuderende + MainViewModel.AntalVoksne) >= 1)
            {
                if (DateTimeConverter.DateTimeOffset(MainViewModel.DateTime) < DateTime.Today)
                {
                    dialog.Content += "Datoen på billet skal være idag eller senere.\n";
                }
                if (MainViewModel.Navn.Length <= 2)
                {
                    dialog.Content += "Navn skal udfyldes med mere end 2 bogstaver.\n";
                }
                if (!regexTelefonNr1.IsMatch(MainViewModel.TelefonNr) && !regexTelefonNr2.IsMatch(MainViewModel.TelefonNr))
                {
                    dialog.Content += "Telefon nummeret er ikke gyldigt.\n";
                }
                if (!regexEmail.IsMatch(MainViewModel.Email))
                {
                    dialog.Content += "Emailen er ikke gyldig.\n";
                }
                if (
                        DateTimeConverter.DateTimeOffset(MainViewModel.DateTime) >= DateTime.Today &&
                        MainViewModel.Navn.Length >= 2 &&
                        (regexTelefonNr1.IsMatch(MainViewModel.TelefonNr) || regexTelefonNr2.IsMatch(MainViewModel.TelefonNr)) &&
                        regexEmail.IsMatch(MainViewModel.Email)
                    )
                {
                    MainViewModel.VikingeCatalogSingleton.Add(MainViewModel.AntalBorn, MainViewModel.AntalStuderende, MainViewModel.AntalVoksne, DateTimeConverter.DateTimeOffset(MainViewModel.DateTime), MainViewModel.Pris, MainViewModel.Sejltur, MainViewModel.Email, MainViewModel.Navn, MainViewModel.TelefonNr);
                    dialog.Content += "Din billet er bestilt: \nNavn: " + MainViewModel.Navn + "\nEmail: " + MainViewModel.Email + "\nTelefon nummer: " + MainViewModel.TelefonNr;
                    switch (MainViewModel.Sejltur)
                    {
                        case true:
                            dialog.Content += "\nSejl tur: Ja";
                            break;
                        case false:
                            dialog.Content += "\nSejl tur: Nej";
                            break;
                        default:
                            break;
                    }
                    if (MainViewModel.AntalVoksne != 0)
                    {
                        dialog.Content += "\nVoksne: " + MainViewModel.AntalVoksne;
                    }
                    if (MainViewModel.AntalBorn != 0)
                    {
                        dialog.Content += "\nBørn: " + MainViewModel.AntalBorn;
                    }
                    if (MainViewModel.AntalStuderende != 0)
                    {
                        dialog.Content += "\nStuderende: " + MainViewModel.AntalStuderende;
                    }
                    dialog.Content += "\nDato: " + DateTimeConverter.DateTimeOffset(MainViewModel.DateTime).ToString("dd/MM/yyyy") + "\nPris: " + Math.Round(MainViewModel.Pris, 2).ToString("N", new CultureInfo("da-DK")) + " kr.";
                }
                if (dialog.Content != "")
                {
                    dialog.ShowAsync();
                }
            }
            else
            {
                dialog.Content += "Alle felter skal udfyldes.";
                dialog.ShowAsync();
            }
        }
    }
}
