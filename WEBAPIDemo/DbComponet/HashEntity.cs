using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace WEBAPIDemo.DbComponet
{
    public static class HashEntity
    {
        public static HashEntry[] ToHashEntries(this object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            var arr = properties.Select(property => new HashEntry(property.Name, property.GetValue(obj).ToString())).ToArray();
            return arr;
        }
    }
}
