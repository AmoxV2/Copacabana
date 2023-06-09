﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

using static System.Net.Mime.MediaTypeNames;

namespace WpfApp1
{
    /*Na plaży Kopakabana oprócz plażowania toczą się też rozgrywki w 3 grach zespołowych: siatkówka plażowa,
     * 2 ognie i przeciąganie liny.Każda z drużyn składa się ze stałej liczby zawodników. 
     * Toczą oni mecze/spotkania na zasadzie każdy z każdym. Pierwsze 4 drużyny z największą liczbą zwycięstw przechodzą do półfinałów a ich zwycięzcy do finałów.
     * Każde ze spotkań sędziuje sędzia, a dodatkowo w siatkówce 2 sędziów pomocniczych.
Minimalny zakres funkcjonalności
zarządzanie sędziami (dodawanie, usuwanie, przegląd)
zarządzanie drużynami (zgłaszanie, wycofywanie, przegląd)
organizacja rozgrywek w każdej dyscyplinie: tworzenie meczów (spotkań), wpisywanie wyników, automatyczne generowanie półfinałów i finałów
wyświetlanie tabeli wyników
zapis i odczyt stanu systemu na dysk*/
    public partial class MainWindow : Window
    {
        
        Rozgrywki rozgrywki = new Rozgrywki();
        public MainWindow()
        {
            InitializeComponent();
            rozgrywki.WczytajStan();
            


        }
        private void ZobaczSędziów(object sender, RoutedEventArgs e)
        {
            OknoObsługiSędziów noweOkno = new OknoObsługiSędziów(rozgrywki);
            noweOkno.ShowDialog();
        }

        private void Zamykanie(object sender, RoutedEventArgs e)
        {

            
            rozgrywki.ZapiszStan();
            Close();
            
        }

        private void Siatkówka(object sender, RoutedEventArgs e)
        {
            OknoObsługiDrużynSiatkówki noweOkno = new OknoObsługiDrużynSiatkówki(rozgrywki);
            noweOkno.ShowDialog();
        }

        private void DwaOgnie(object sender, RoutedEventArgs e)
        {
            OknoObsługiDrużynDwaOgnie noweOkno = new OknoObsługiDrużynDwaOgnie(rozgrywki);
            noweOkno.ShowDialog();
        }

        private void PrzeciaganieLiny(object sender, RoutedEventArgs e)
        {
            OknoObsługiDrużynPrzeciąganieLiny noweOkno = new OknoObsługiDrużynPrzeciąganieLiny(rozgrywki);
            noweOkno.ShowDialog();
        }
    }
}
