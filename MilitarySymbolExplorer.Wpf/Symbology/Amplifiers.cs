using MilitarySymbolExplorer.Wpf.Converters;
using System.ComponentModel;

namespace MilitarySymbolExplorer.Wpf.Symbology
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum BaseAmplifier
    {
        [Description("Not Applicable")]
        NotApplicable,
        [Description("Echelon at Brigade and below")]
        BrigadeBelowEchelon,
        [Description("Echelon at Division and above")]
        DivisionAboveEcholon,
        [Description("Equipment mobility on land")]
        EquipmentMobilityOnLand,
        [Description("Equipment mobility on snow")]
        EquipmentMobilityOnSnow,
        [Description("Equipment mobility on water")]
        EquipmentMobilityOnWater,
        [Description("Naval towed array")]
        NavalTowedArray
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum BrigadeBelowEchelonAmplifier {
        [Description("Team/Crew")]
        Team =1,
        Squad=2,
        Section=3,
        [Description("Platoon/Deatachment")]
        Platoon =4,
        [Description("Company/Battery/Troop")]
        Company =5,
        [Description("Battalion/Squadron")]
        Battalion =6,
        [Description("Regiment/Group")]
        Regiment =7,
        Brigade=8
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum DivisionAboveEchelonAmplifier {
        Division=1,
        Corp =2,
        Army=3,
        [Description("Army Group/Front")]
        ArmyGroup =4,
        [Description("Region/Theater")]
        Region =5,
        Command=6
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EquipmentMobilityOnLandAmplifier {
        [Description("Wheeled limited cross country")]
        WheeledLimitedCrossCountry = 1,
        [Description("Wheeled cross country")]
        WheeledCrossCountry = 2,
        Tracked = 3,
        [Description("Wheeled and tracked combination")]
        WheeledAndTrackedCombination = 4,
        Towed,
        Rail,
        [Description("Pack animals")]
        PackAnimals
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum EquipmentMobilityOnSnowAmplifier {
        [Description("Oversnow(prime mover)")]
        OverSnow = 1,
        Sled = 2
    }

    public enum EquipmentMobilityOnWaterAmplifier {
        Barge=1,
        Amphibious =2
    }

    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum NavalTowedArrayAmplifier
    {
        [Description("Short towed array")]
        ShortTowedArray =1,
        [Description("Long towed array")]
        LongTowedArray =2,
    }
}
