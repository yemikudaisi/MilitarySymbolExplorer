using System;
using MilitarySymbolExplorer.Wpf.Extensions;

namespace MilitarySymbolExplorer.Wpf.Symbology
{
    public class Amplifier
    {
        private string _extensionValue;

        public BaseAmplifier Base{get; set;}
        public object Extension{
            get{
                switch (Base)
                {
                    case BaseAmplifier.BrigadeBelowEchelon:
                        return Enum.Parse(typeof(BrigadeBelowEchelonAmplifier), _extensionValue);
                    case BaseAmplifier.DivisionAboveEcholon:
                        return Enum.Parse(typeof(DivisionAboveEchelonAmplifier), _extensionValue);
                    case BaseAmplifier.EquipmentMobilityOnLand:
                        return Enum.Parse(typeof(EquipmentMobilityOnLandAmplifier), _extensionValue);
                    case BaseAmplifier.EquipmentMobilityOnSnow:
                        return Enum.Parse(typeof(EquipmentMobilityOnSnowAmplifier), _extensionValue);
                    case BaseAmplifier.EquipmentMobilityOnWater:
                        return Enum.Parse(typeof(EquipmentMobilityOnWaterAmplifier), _extensionValue);
                    case BaseAmplifier.NavalTowedArray:
                        return Enum.Parse(typeof(NavalTowedArrayAmplifier), _extensionValue);
                    case BaseAmplifier.NotApplicable:
                        return null;
                    default:
                        throw new Exception("Invalid");
                }
            }

            set
            {
                _extensionValue = value.ToString();
            }
        }

        public override string ToString()
        {
            string ext="00";
            switch (Base)
            {
                case BaseAmplifier.BrigadeBelowEchelon:
                    ext = ((BrigadeBelowEchelonAmplifier)Enum.Parse(typeof(BrigadeBelowEchelonAmplifier), _extensionValue)).GetString();
                    break;
                case BaseAmplifier.DivisionAboveEcholon:
                    ext = ((DivisionAboveEchelonAmplifier)Enum.Parse(typeof(DivisionAboveEchelonAmplifier), _extensionValue)).GetString();
                    break;
                case BaseAmplifier.EquipmentMobilityOnLand:
                    ext = ((EquipmentMobilityOnLandAmplifier)Enum.Parse(typeof(EquipmentMobilityOnLandAmplifier), _extensionValue)).GetString();
                    break;
                case BaseAmplifier.EquipmentMobilityOnSnow:
                    ext = ((EquipmentMobilityOnSnowAmplifier)Enum.Parse(typeof(EquipmentMobilityOnSnowAmplifier), _extensionValue)).GetString();
                    break;
                case BaseAmplifier.EquipmentMobilityOnWater:
                    ext = ((EquipmentMobilityOnWaterAmplifier)Enum.Parse(typeof(EquipmentMobilityOnWaterAmplifier), _extensionValue)).GetString();
                    break;
                case BaseAmplifier.NavalTowedArray:
                    ext = ((NavalTowedArrayAmplifier)Enum.Parse(typeof(NavalTowedArrayAmplifier), _extensionValue)).GetString();
                    break;
            }
            return $"{Base.GetString()}{ext}";
        }
    }
}
