using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webblog.extention
{
    public static class session
    {
        public static void set<T>(this ISession session, string key ,T value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));

        }
        public static T get<T>(this ISession session,string key)
        {
            var value = session.GetString(key);
            return value == null ? default(T) : JsonConvert.DeserializeObject<T>(value);
        }
    }
}
