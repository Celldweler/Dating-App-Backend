using DatingApp.Data.Utils;

namespace DatingApp.Data
{
    public static class Constants
    {
        public static readonly string SQLITE_CONNECTION_STRING = $"Data source={Helpers.GetSqlliteDbPath}";
        public const string SOLUTION_BASE_PATH =
        @"C:\Users\Raime\source\repos\my-pet-projects\DatingApp\Dating-App-Backend\src";
    }
}