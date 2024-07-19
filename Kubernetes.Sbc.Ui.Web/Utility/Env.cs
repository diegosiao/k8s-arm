namespace Kubernetes.Sbc.Ui.Web.Utility
{
    public static class Env
    {
        public static string? ROOT_PATH => nameof(ROOT_PATH).GetEnv();

        public static string? WEATHER_SERVICE => nameof(WEATHER_SERVICE).GetEnv();

        private static string? GetEnv(this string key, bool required = true)
        {
            var env = Environment.GetEnvironmentVariable(key);

            if (required && string.IsNullOrEmpty(env))
            {
                throw new InvalidOperationException($"The required environment variable '{key}' is missing. ");
            }

            return env;
        }
    }
}
