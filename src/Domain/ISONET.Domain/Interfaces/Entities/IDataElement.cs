using System.Collections.Generic;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IDataElement
    {
        IAttribute Attribute { get; }
        short Bit { get; }
        IRule Rule { get; }
        string Description { get; set; }
        string Name { get; }
        IList<IDataObject> DataObjects { get; set; }

        string toTypeLengthValue();
    }
}