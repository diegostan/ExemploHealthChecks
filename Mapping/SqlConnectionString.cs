namespace HealthCheck.Mapping
{
    public static class SqlConnectionString
    {
        public static string GetConnectionString()
        {
            return "Server=.\\SQLExpress; Database=Pets; Integrated Security=True";
        }
    }
}