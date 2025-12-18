namespace Project__part_A_
{
    public class Account
    {
        public string Email { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public void ChangePassword(string newPass)
        {
            throw new NotImplementedException(); // Заглушка
        }
    }
}