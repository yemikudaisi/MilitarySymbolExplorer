using str = MilitarySymbolExplorer.Wpf.Infrastructure.StringAttribute;
using System.ComponentModel;

namespace MilitarySymbolExplorer.Wpf.Symbology
{
    public enum AirEntities
    {
        [str("00")][Description("Not applicable")] NotApplicable=00,
        Military = 11,
        Civilian = 12,
        Weapon = 13,
        [Description("Manual track")] ManualTrack = 14
    }

    public enum MilitaryAirEntityTypes
    {

    }

    public enum CivilianAirEntityTypes
    {

    }

    public enum WeaponAirEntityTypes{}

    public enum ManualTrackAirEntityTypes { }
}
