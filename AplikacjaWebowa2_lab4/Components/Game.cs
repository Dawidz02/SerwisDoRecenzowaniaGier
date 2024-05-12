namespace AplikacjaWebowa2_lab4.Components
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public DateOnly? ReleaseDate { get; set; }
        public List<float>? Rate { get; set; }
        public float? Metacritic { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public float? AverageRate { get; set; }
        public void AddRate(float newRate)
        {
            if (Rate == null)
                Rate = new List<float>();

            Rate.Add(newRate);
            CalculateAverageRate();
        }

        private void CalculateAverageRate()
        {
            if (Rate == null || Rate.Count == 0)
            {
                AverageRate = null;
            }
            else
            {
                AverageRate = Rate.Average();
            }
        }
    }
}
