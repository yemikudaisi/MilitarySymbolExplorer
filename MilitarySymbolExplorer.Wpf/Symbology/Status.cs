using MilitarySymbolExplorer.Wpf.Converters;
using System.ComponentModel;

namespace MilitarySymbolExplorer.Wpf.Symbology
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum Status
    {
        Present,
        [Description("Planned/Anticipated/Suspect")]
        Planned,
        [Description("Present/Fully Capable")]
        PresentFullyCapable,
        [Description("Present/Damaged")]
        PresentDamaged,
        [Description("Present/Destroyed")]
        PresentDestroyed,
        [Description("Present/Full to Capacity")]
        PresentFullToCapacity
    }
}
