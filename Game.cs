namespace Project__part_A_
{
    public class Game : ILibraryItem // Реалізація інтерфейсу
    {
        public string Title { get; set; } = null!;
        public double SizeGb { get; set; }
        public double Price { get; set; }
        public Genre GameGenre { get; set; }

        // Асоціація: гра має посилання на розробника
        public Developer Creator { get; set; } = null!;

        public void Install() => throw new NotImplementedException();
        public void Uninstall() => throw new NotImplementedException();
        public void DisplayInfo() => throw new NotImplementedException();
    }
}