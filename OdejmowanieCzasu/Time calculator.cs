namespace OdejmowanieCzasu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calculate_Click_1(object sender, EventArgs e)
        {
            // Pobranie dat od u¿ytkownika
            DateTime startDate = startdate.Value;
            DateTime endDate = enddate.Value;

            // Obliczenie ró¿nicy dni
            TimeSpan difference = endDate - startDate;
            int daysDifference = difference.Days;

            // Wyœwietlenie wyniku w etykiecie
            result.Text = $"Result: since first date: {daysDifference} days have passed";
        }
    }
}
