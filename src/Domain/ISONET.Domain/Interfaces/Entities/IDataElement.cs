﻿using ISONET.Domain.Entities;
using System.Collections.Generic;

namespace ISONET.Domain.Interfaces.Entities
{
	public interface IDataElement
	{
		IAttribute Attribute { get; }
		short Bit { get; }
		string Description { get; set; }
		string Name { get; }
		ConditionUse ConditionUse { get; }
		string Value { get; set; }
		IEnumerable<IDataObject> DataObjects { get; set; }

		string ToTypeLengthValue();

		IEnumerable<IDataObject> Split(string isoMessage);
	}
}