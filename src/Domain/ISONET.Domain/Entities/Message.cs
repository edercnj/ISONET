using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using System;
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

        public Message(int mti, string messageName, IEnumerable<IDataElement> dataElements, string header = @"") : this(mti, messageName, dataElements)
        {
            Header = header;
        }

        public Message(int mti, string messageName, IEnumerable<IDataElement> dataElements)
        {
            Mti = mti;
            MessageName = messageName;
            DataElements = dataElements;
            BitMap = this.DataElementsToBitMap();

            if (!this.BitMapIsValid())
                throw new ApplicationException(@"Mapa de Bits Inválido.");//TODO: Melhorar essa mensagem de Exceção para identificar quais bits estão errados.
        }

        public int Mti
        {
            get => int.Parse(_mti.ToString(@"D4"));
            set => _mti = value;
        }

        public string MessageName
        {
            get => _messageName;
            set => _messageName = value;
        }

        public bool[] BitMap { get => _bitMap; set => _bitMap = value; }

        public IEnumerable<IDataElement> DataElements
        {
            get => _dataElements;
            set => _dataElements = value;
        }

        public string Header
        {
            get => _header;
            set => _header = value;
        }

        public sealed override string ToString() => Header + Mti.ToString(@"D4") + BitMap.BoolArrayToHexa() + DataElements.Aggregate(string.Empty, (current, element) => current + element.ToString());
    }
}