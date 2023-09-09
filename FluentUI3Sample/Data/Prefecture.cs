namespace FluentUI3Sample.Data
{
    public class Prefecture
    {
        public Prefecture(string name, string capital, int population, string retion) 
        {
            Name = name;
            Capital = capital;
            Population = population;
            Region = retion;
        }
        public string Name { get; set; }
        public string Capital { get; set; }
        public int Population { get; set; }
        public string Region { get; set; }
    }
}
