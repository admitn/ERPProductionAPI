namespace ERPProductionAPI.Models
{
    public class AppSettings
    {
        public string Host { get; set; } = string.Empty;
        public string Db { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        // Дополнительное свойство для проверки
        public bool IsValid => !string.IsNullOrEmpty(Host) && !string.IsNullOrEmpty(Db);
    }
}
