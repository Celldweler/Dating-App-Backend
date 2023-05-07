using System;
using System.IO;

namespace DatingApp.Data.Utils
{
    public static class Helpers
    {
        public static bool IsDevelopment()
        {
            var res = Environment.GetEnvironmentVariables();

            return true;
        }

        public static string GetSqlliteDbPath => @$"{Constants.SOLUTION_BASE_PATH}\DatingApp.Data\datingapp.db";
    }
}