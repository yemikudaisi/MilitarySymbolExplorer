using MilitarySymbolExplorer.Wpf.Extensions;
using MilitarySymbolExplorer.Wpf.Symbology.SymbolSets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySymbolExplorer.Wpf.Symbology
{
    public class Symbol
    {
        public Symbol() { }
        public Symbol(string version, StandardEnityOnes standardEntityOne, StandardEntityTwos standardEntityTwo, SymbolSet symbolSet, Status status, HQTFDummy hQTFDummy, Amplifier amplifier, Entity entity, EntityType entityType, EntitySubType entitySubType, Modifier modifierOne, Modifier modifierTwo)
        {
            Version = version;
            StandardEntityOne = standardEntityOne;
            StandardEntityTwo = standardEntityTwo;
            SymbolSet = symbolSet;
            Status = status;
            HQTFDummy = hQTFDummy;
            Amplifier = amplifier;
            Entity = entity;
            EntityType = entityType;
            EntitySubType = entitySubType;
            ModifierOne = modifierOne;
            ModifierTwo = modifierTwo;
        }

        public string Version { get; set; } = "10";
        public StandardEnityOnes StandardEntityOne { get; set; } = StandardEnityOnes.Reality;
        public StandardEntityTwos StandardEntityTwo { get; set; } = StandardEntityTwos.Friend;
        public SymbolSet SymbolSet { get; set; } = SymbolSet.LandUnits;
        public Status Status { get; set; } = Status.Present;
        public HQTFDummy HQTFDummy { get; set; } = HQTFDummy.NotApplicable;
        public Amplifier Amplifier { get; set; } = new Amplifier { Base = BaseAmplifier.BrigadeBelowEchelon, Extension = BrigadeBelowEchelonAmplifier.Company };
        public Entity Entity { get; set; } = new Entity("Fires", "13");
        public EntityType EntityType { get; set; } = (new EntityType("", "00"));
        public EntitySubType EntitySubType { get; set; } = (new EntitySubType("", "00"));
        public Modifier ModifierOne { get; set; } = new Modifier("", "00");
        public Modifier ModifierTwo { get; set; } = new Modifier("", "00");

        public string SetA { get => $"{Version}" +
                $"{StandardEntityOne.GetString()}" +
                $"{StandardEntityTwo.GetString()}" +
                $"{SymbolSet.GetString()}" +
                $"{Status.GetString()}" +
                $"{HQTFDummy.GetString()}" +
                $"{Amplifier}"; }
        public string SetB { get => $"{Entity.Identifier}" +
                $"{EntityType.Identifier}" +
                $"{EntitySubType.Identifier}" +
                $"{ModifierOne.Identifier}" +
                $"{ModifierTwo.Identifier}"; }

        public override string ToString()
        {
            return $"{Version}" +
                $"{StandardEntityOne.GetString()}" +
                $"{StandardEntityTwo.GetString()}" +
                $"{SymbolSet.GetString()}" +
                $"{Status.GetString()}" +
                $"{HQTFDummy.GetString()}" +
                $"{Amplifier} " +
                $"{Entity.Identifier}" +
                $"{EntityType.Identifier}" +
                $"{EntitySubType.Identifier}" +
                $"{ModifierOne.Identifier}" +
                $"{ModifierTwo.Identifier}";
        }
    }
}
