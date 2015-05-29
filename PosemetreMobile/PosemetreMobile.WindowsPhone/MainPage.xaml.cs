using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PosemètreCore.données;
using PosemetreMobile.relais;
using PosemètreCore.actions;
using PosemètreCore.annuaires;
using PosemètreCore.ModesDeFonctionement;
using PosemetreMobile.Collection;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace PosemetreMobile
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.initialiserModes();
            this.initialiserOuverture();
            this.initialiserTempsDePose();

            mesurer.Visibility = Windows.UI.Xaml.Visibility.Collapsed;

            this.NavigationCacheMode = NavigationCacheMode.Required;

        }

        private void initialiserModes()
        {
            mode.ItemsSource = AnnuaireDeModesDeFonctionnement.Modes;
            mode.DisplayMemberPath = "fournirUnLibellé";
        }

        private void initialiserOuverture()
        {
            ouverture.ItemsSource = Ouverture.récupérerToutesLesValeuresDOuverture();

            ouverture.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void initialiserTempsDePose()
        {
            tempsDePose.ItemsSource = TempsDePose.récupérerAnnuaire().Select(item => new ClésValeursPourCombobox<double, string> { Key = item.Key, Value = item.Value });
            tempsDePose.DisplayMemberPath = "Value";
            tempsDePose.SelectedValuePath = "Key";

            tempsDePose.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
        }

        private void mesurer_Click(object sender, RoutedEventArgs e)
        {
            double valeurIso = System.Convert.ToDouble(this.saisieISO.Text);
            double valeurOuverture = (double)ouverture.SelectedItem;
            ModeDeFonctionement modeChoisi = (ModeDeFonctionement)mode.SelectedItem;

            Posemètre posemètre = new Posemètre();
            posemètre.setISO(valeurIso);
            posemètre.setOuverture(valeurOuverture);

            RelaiCommandesCalcul relais = new RelaiCommandesCalcul();

            posemètre = relais.executerCommande(modeChoisi.aPourAction, posemètre);

            this.affichageRésultat.Text = posemètre.getTempsDePose().ToString();
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

    }
}
