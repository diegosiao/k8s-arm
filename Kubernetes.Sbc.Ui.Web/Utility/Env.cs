namespace Kubernetes.Sbc.Ui.Web.Utility
{
    public static class Env
    {
        public static string? ROOT_PATH => nameof(ROOT_PATH).GetEnv();

        public static string? SERVICE_ASIA_WEATHER => nameof(SERVICE_ASIA_WEATHER).GetEnv();

        public static string? SERVICE_EUROPE_WEATHER => nameof(SERVICE_EUROPE_WEATHER).GetEnv();

        public static string? SERVICE_SOUTHAMERICA_WEATHER => nameof(SERVICE_SOUTHAMERICA_WEATHER).GetEnv();

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
