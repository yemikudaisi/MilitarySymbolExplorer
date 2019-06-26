using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilitarySymbolExplorer.Wpf.Symbology.SymbolSets
{
    public class EntityType : Identity
    {
        protected EntityType(string name, string identifier, IList<EntitySubType> types)
        : base(name, identifier)
        {
            SubTypes = types;
        }

        public IList<EntitySubType> SubTypes { get; set; }
    }
}
