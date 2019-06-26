using MilitarySymbolExplorer.Wpf.Converters;
using System.ComponentModel;

namespace MilitarySymbolExplorer.Wpf.Symbology
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum HQTFDummy
    {
        [Description("Not Applicable")]
        NotApplicable,
        [Description("Fient/Dummy")]
        FientDummy,
        Headquarters,
        [Description("Fient/ Dummy Headquarters")]
        FientDummyHeadquarters,
        [Description("Task Force")]
        TaskForce,
        [Description("Fient/Dummy Task Force")]
        FientDummyTaskforce,
        [Description("Task Force Headquarters")]
        TaskForceHeadquarters,
        [Description("Fient/ Dummy Task Force Headquarters")]
        FientDummyTaskforceHeadquarters
    }
}
