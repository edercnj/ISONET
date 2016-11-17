using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;

namespace ISONET.Application
{
    public class DataObjectApplication
    {
        public static IDataObject CreateDataObject(string type, short length, string value)
        {
            IDataObject dataObject = new DataObject(type, length, value);

            return dataObject;
        }

        public static IDataObject CreateDataObject(string type, short length)
        {
            IDataObject dataObject = new DataObject(type, length);

            return dataObject;
        }
    }
}