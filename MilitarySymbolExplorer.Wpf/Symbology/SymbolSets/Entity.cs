using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySymbolExplorer.Wpf.Symbology.SymbolSets
{
    public class Entity : DomainCoded
    {
        private EntityType _type;
        private EntitySubType _subType;

        public EntityType Type { get { return _type; } }
        public EntitySubType SubType { get { return _subType; } }

        public Entity(string name, string identifier)
            : base(name, identifier)
        {
        }

        public Entity SetType(EntityType type)
        {
            _type = type;
            return this;
        }
        public Entity SetSubType(EntitySubType type)
        {
            _subType = type;
            return this;
        }
    }
}
