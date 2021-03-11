using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment_8_Joisah_Sarles.Infrastructure
{
    //tool to convert cart to json objects and back to store in the session
    public static class SessionExtensions
    {

        public static void SetJson(this ISession sesh, string key, object value)
        {
            sesh.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T GetJson<T>(this ISession sesh, string key)
        {
            var seshData = sesh.GetString(key);

            return seshData == null ? default(T) : JsonSerializer.Deserialize<T>(seshData);
        }
    }
}
