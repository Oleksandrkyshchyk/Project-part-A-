using System;

namespace Project__part_A_
{
    public abstract class LibraryItem : ILibraryItem
    {
        public string Title { get; set; } = null!;
        public double SizeGb { get; set; }
        public double Price { get; set; }

        public abstract void Install();
        public abstract void Uninstall();
        public abstract void DisplayInfo();

        public int CompareTo(ILibraryItem? other) => throw new NotImplementedException();
        public object Clone() => throw new NotImplementedException();
    }
}