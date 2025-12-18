namespace Project__part_A_
{
    public class Game : LibraryItem
    {
        public Genre GameGenre { get; set; }
        public Developer Creator { get; set; } = null!;

        public bool IsInstalled { get; set; }

        public override void Install() => throw new NotImplementedException();
        public override void Uninstall() => throw new NotImplementedException();
        public override void DisplayInfo() => throw new NotImplementedException();
    }
}