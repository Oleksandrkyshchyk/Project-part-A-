namespace Project__part_A_
{
    // Інтерфейс визначає загальні вимоги до елементів бібліотеки
    public interface ILibraryItem
    {
        // Властивості (тільки сигнатури)
        string Title { get; set; }
        double SizeGb { get; set; }

        // Методи (тільки сигнатури без тіла)
        void Install();
        void Uninstall();
    }
}
