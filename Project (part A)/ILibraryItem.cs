using System;

namespace Project__part_A_
{
    public interface ILibraryItem : IComparable<ILibraryItem>, ICloneable
    {
        string Title { get; set; }
        double SizeGb { get; set; }
        double Price { get; set; }
        void Install();
    }
}