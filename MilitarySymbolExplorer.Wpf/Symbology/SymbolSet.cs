using MilitarySymbolExplorer.Wpf.Converters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using str = MilitarySymbolExplorer.Wpf.Infrastructure.StringAttribute;

namespace MilitarySymbolExplorer.Wpf.Symbology
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum SymbolSet
    {
        //Note: Using GetString to get value
        [str("01")] Air = 01,
        [Description("Air Missile")]
        [str("02")]AirMissile = 02,
        [str("05")] Space = 05,
        [Description("Space Missile")]
        [str("06")] SpaceMissile = 06,
        [Description("Land Units")]
        [str("10")] LandUnits = 10,
        [Description("Land Civilian")]
        LandCivilian = 11,
        [Description("Land Equipment")]
        LandEquipment =15,
        [Description("Land Installation")]
        LandInstallation = 20,
        [Description("Control Measure")]
        ControlMeasure = 25,
        [Description("Control Measure")]
        SeaSurface =30,
        [Description("Sea Surface")]
        SeaSubsurface = 35,
        [Description("Mine Warfare")]
        MineWarfare = 36,
        Activities = 40,
        [Description("Meteorological - Atmospheric")]
        MeteorologicalAtmospheric = 45,
        [Description("Meteorological - Oceanpgraphic")]
        MeteorologicalOceanographic =46,
        [Description("Meteorological - Space")]
        MeteorologicalSpace = 47,
        [Description("Signals Intelligence -Space")]
        SignalsIntelligenceSpace = 50,
        [Description("Signals Intelligence - Air")]
        SignalsIntelligenceAir = 51,
        [Description("Signals Intelligence - Land")]
        SignalsIntelligenceLand = 52,
        [Description("Signals Intelligence - Surface")]
        SignalsIntelligenceSurface = 53,
        [Description("Signals Intelligence - Subsurface")]
        SignalsIntelligenceSubsurface = 54,
        Cyberspace = 60
    }
}
