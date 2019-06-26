using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySymbolExplorer.Wpf.Symbology.SymbolSets
{
    public abstract class Entity : Identity
    {
        protected Entity(string name, string identifier, IList<EntityType> types)
            : base(name, identifier)
        {
            Types = types;
        }

        public IList<EntityType> Types { get; set; }
    }
}
