using ISONET.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ISONET.Infra.Data.Context
{
    public class ConfigurationContext : DbContext
    {
        public DbSet<DataElement> DataElement { get; set; }
        public DbSet<DataObject> DataObject { get; set; }
        public DbSet<DataElementAttribute> DataElementAttribute { get; set; }
        public DbSet<Message> Message { get; set; }
    }
}