namespace TestApi.Common
{
    public static class EnumExtensions
    {
        public static string GenerateString(this Enum code)
        {
            return code.ToString();
        }
    }
}
