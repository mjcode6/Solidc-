using System;

namespace solid
{
    public class  Factory
    {
        public Production Craft(IEnumerable<Craftable> craftables)
    {
        Production newProduction = new Production(craftables);
        return newProduction;
    }
    }
}
