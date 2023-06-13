using System.Text.Json;
using CampingApp.Mvc.Models;

namespace CampingApp.Mvc.extensions
{
    public static class SessionExtensions
    {
        public static void SetJson<T>(this ISession session, string key, T value)
        {
            var serialized = JsonSerializer.Serialize<T>(value);
            session.SetString(key, serialized);
        }

        public static T? GetJson<T>(this ISession session, string key)
        {
            var serializedString = session.Get(key);
            return serializedString == null ? default(T) : JsonSerializer.Deserialize<T>(serializedString);
        }
    }
}
