using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using WPFStampante.Models;

namespace WPFStampante
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Stampante stampante;
        private const string filePath = "stampanteCsv.csv";

        public MainWindow()
        {
            InitializeComponent();

            stampante = new Stampante();

            stampante.CaricaStatoDaFile(filePath);

            ciano.Text = Convert.ToString(stampante.StatoInchiostro(0));
            magenta.Text = Convert.ToString(stampante.StatoInchiostro(2));
            giallo.Text = Convert.ToString(stampante.StatoInchiostro(1));
            nero.Text = Convert.ToString(stampante.StatoInchiostro(3));
            Fogli.Text = Convert.ToString(stampante.StatoCarta());

            this.Closing += MainWindow_Closing;
        }
        private void Stampa_Click(object sender, RoutedEventArgs e)
        {
            Pagina pagina = new Pagina(Convert.ToInt32(ValCiano.Text), Convert.ToInt32(ValGiallo.Text), Convert.ToInt32(ValGiallo.Text), Convert.ToInt32(ValNero.Text));
            stampante.Stampa(pagina);
            ciano.Text = Convert.ToString(stampante.StatoInchiostro(0));
            magenta.Text = Convert.ToString(stampante.StatoInchiostro(2));
            giallo.Text = Convert.ToString(stampante.StatoInchiostro(1));
            nero.Text = Convert.ToString(stampante.StatoInchiostro(3));
            Fogli.Text = Convert.ToString(stampante.StatoCarta());
        }
        private void StampaRandom_Click(object sender, RoutedEventArgs e)
        {

            Pagina pagina = new Pagina();
            stampante.Stampa(pagina);
            ciano.Text = Convert.ToString(stampante.StatoInchiostro(0));
            magenta.Text = Convert.ToString(stampante.StatoInchiostro(2));
            giallo.Text = Convert.ToString(stampante.StatoInchiostro(1));
            nero.Text = Convert.ToString(stampante.StatoInchiostro(3));
            Fogli.Text = Convert.ToString(stampante.StatoCarta());
        }


        private void ControlloValore(object sender, TextCompositionEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            // Verifica se il riferimento a TextBox è nullo
            if (textBox != null)
            {
                // Controlla se il testo inserito è tra i caratteri consentiti
                if ((e.Text != "0" && e.Text != "1" && e.Text != "2" && e.Text != "3") || textBox.Text.Length >= 1)
                {
                    e.Handled = true; // Impedisci l'inserimento del carattere
                }
            }
        }

        private void riempiCiano_Click(object sender, RoutedEventArgs e)
        {
            stampante.SostituisciColore(0);
            ciano.Text = Convert.ToString(stampante.StatoInchiostro(0));
        }

        private void riempiGiallo_Click(object sender, RoutedEventArgs e)
        {
            stampante.SostituisciColore(1);
            giallo.Text = Convert.ToString(stampante.StatoInchiostro(1));
        }

        private void riempiMagenta_Click(object sender, RoutedEventArgs e)
        {
            stampante.SostituisciColore(2);
            magenta.Text = Convert.ToString(stampante.StatoInchiostro(2));
        }

        private void riempiNero_Click(object sender, RoutedEventArgs e)
        {
            stampante.SostituisciColore(3);
            nero.Text = Convert.ToString(stampante.StatoInchiostro(3));
        }

        private void RicaricaFogli_Click(object sender, RoutedEventArgs e)
        {
            stampante.AggiungiCarta(Convert.ToInt32(ValFogli.Text));
            Fogli.Text = Convert.ToString(stampante.StatoCarta());

        }
        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            stampante.SalvaStatoSuFile(filePath);
        }
    }
}