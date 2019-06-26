using MilitarySymbolExplorer.Wpf.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySymbolExplorer.Wpf.Extensions
{
    public static class EnumExtension
    {
        public static string Description(this Enum val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val
               .GetType()
               .GetField(val.ToString())
               .GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }

        public static TAttribute GetAttribute<TAttribute>(this Enum value)
        where TAttribute : Attribute
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            return type.GetField(name) // I prefer to get attributes this way
                .GetCustomAttributes(false)
                .OfType<TAttribute>()
                .SingleOrDefault();
        }

        public static String GetString(this Enum value)
        {
            var type = value.GetType();
            var name = Enum.GetName(type, value);
            var stringAttribute =  type.GetField(name) // I prefer to get attributes this way
                .GetCustomAttributes(false)
                .OfType<StringAttribute>()
                .SingleOrDefault();
            //var x = value.GetType().GetField(value.ToString());
            if(stringAttribute==null)
                return Convert.ToInt32(Enum.Parse(type, value.ToString())).ToString();
            return stringAttribute.Value;
        }
    }
}
