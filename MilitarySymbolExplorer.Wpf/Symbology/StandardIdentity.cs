using MilitarySymbolExplorer.Wpf.Converters;
using System.ComponentModel;

namespace MilitarySymbolExplorer.Wpf.Symbology
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum StandardIdentity
    {
        Pending,
        Unknown,
        [Description("Assumed Friend")]
        AssumedFriend,
        Friend,
        Neutral,
        [Description("Suspect/Joker")]
        Suspect,
        [Description("Hostile/Faker")]
        Hostile          
    }
}
