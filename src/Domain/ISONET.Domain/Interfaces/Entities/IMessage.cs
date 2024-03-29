﻿using System.Collections.Generic;

namespace ISONET.Domain.Interfaces.Entities
{
    public interface IMessage
    {
        string Header { get; set; }
        int Mti { get; set; }
        string MessageName { get; set; }
        bool[] BitMap { get; set; }
        IEnumerable<IDataElement> DataElements { get; set; }

    }
}