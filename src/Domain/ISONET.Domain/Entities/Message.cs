using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using System.Collections.Generic;
using System.Linq;

namespace ISONET.Domain.Entities
{
	public class Message : IMessage
	{
		private int _mti;
		private string _messageName;
		private bool[] _bitMap;
		private IEnumerable<IDataElement> _dataElements;
		private string _header;

		public Message(int mti, string messageName, bool[] bitMap, IEnumerable<IDataElement> dataElements, string header = "")
		{
			Mti = mti;
			MessageName = messageName;
			BitMap = bitMap;
			DataElements = dataElements;
			Header = header;
		}

		public Message(int mti, string messageName, bool[] bitMap, IEnumerable<IDataElement> dataElements)
		{
			Mti = mti;
			MessageName = messageName;
			BitMap = bitMap;
			DataElements = dataElements;
		}

		public int Mti { get { return int.Parse(_mti.ToString("D4")); } set { _mti = value; } }

		public string MessageName { get { return _messageName; } set { _messageName = value; } }

		public bool[] BitMap { get { return _bitMap; } set { _bitMap = value; } }

		public IEnumerable<IDataElement> DataElements { get { return _dataElements; } set { _dataElements = value; } }

		public string Header { get { return _header; } set { _header = value; } }

		public IEnumerable<IDataElement> Split(string isoMessage)
		{
			IEnumerable<IDataElement> elements = new List<IDataElement>();
			int index = Header.Length + Mti.ToString().Length;

			foreach (IDataElement dataElement in elements)
			{
				dataElement.Value = isoMessage.Substring(index, dataElement.Attribute.Length);
				index += dataElement.Attribute.Length;
			}

			return elements;
		}

		public override string ToString()
		{
			return Header + Mti.ToString("D4") + BitMap.BoolArrayToHexa() + DataElements.Aggregate(string.Empty, (current, element) => current + element.ToString());
		}
	}
}