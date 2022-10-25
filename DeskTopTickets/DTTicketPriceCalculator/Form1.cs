using MoviesDataLayer;
using MoviesDataLayer.Models;

namespace DTTicketPriceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            perfDate.Format = DateTimePickerFormat.Custom;
            perfDate.CustomFormat = "MM/dd/yyyy";

            perfTime.Format = DateTimePickerFormat.Custom;
            perfTime.CustomFormat = "HH:mm";

            moviesList.DataSource = GetAllMovies();
            moviesList.DisplayMember = "Title";
            moviesList.ValueMember = "MovieId";

            ticketDetailsGroupBox.Visible = false;
        }


        private List<Movie> GetAllMovies()
        {
            EFMoviesDBFirst movies = new EFMoviesDBFirst();
            return movies.GetAllMovies();

        }

        private CustomerTicket GetTicket(int movieId, int adultCount, int childCount, string date, string time)
        {
            EFMoviesDBFirst movies = new EFMoviesDBFirst();
            Movie movie = movies.GetMovieById(movieId);


            CustomerTicket ticket = new CustomerTicket
            {
                FilmID = movieId.ToString(),
                Title = movie.Title,
                AdultCount = adultCount,
                ChildCount = childCount,
                Date = date,
                Time = time
            };

            return ticket;
        }

        private void GetTicketButton_Click(object sender, EventArgs e)
        {
            if (perfDate.Value.Date < DateTime.Now)
            {
                MessageBox.Show("Performance date and time must be in the future");
                return;
            }

            int numAdults = (int)numOfAdultsNUD.Value;
            int numChildren = (int)numOfChildrenNUD.Value;

            string date = perfDate.Value.ToShortDateString();
            string time = perfTime.Value.ToShortTimeString();

            int movieId = (int)moviesList.SelectedValue;

            CustomerTicket ticket = GetTicket(movieId, numAdults, numChildren, date, time);

            filmNameLabel.Text = ticket.Title;
            dateLabel.Text = ticket.Date;
            timeLabel.Text = ticket.Time;
            ticketChoiceLabel.Text = $"{ticket.AdultCount} adult{(ticket.AdultCount == 1? String.Empty:"s")} and {ticket.ChildCount} child{(ticket.ChildCount == 1? String.Empty:"ren")}";
            totalCostLabel.Text = $"Total Price: {ticket.TotalPrice:C}";

            ticketDetailsGroupBox.Visible = true;

        }
    }
}