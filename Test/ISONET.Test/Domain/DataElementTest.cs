using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ISONET.Test.Domain
{
	[TestClass]
	public class DataElementTest
	{
		private IDataElement de03, de07, de10, de11, de12, de52;

		[TestInitialize]
		public void TestInitialize()
		{
			de03 = new DataElement(new Attribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.NoMask }, 6, 6), 3, "PCode", "PCode", ConditionUse.Mandatory, "991000");
			de07 = new DataElement(new Attribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLVAR, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 10, 10), 7, "Data e Hora GMT", "Data e Hora GMT", ConditionUse.Mandatory, "2106150513");
			de10 = new DataElement(new Attribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLLVAR, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 15, 15), 10, "Test LLLVAR", "Test LLLVAR", ConditionUse.Mandatory, "00000124567895A");
			de11 = new DataElement(new Attribute(new[] { AttributeFormat.NUMERIC, AttributeFormat.ALPHABETICAL }, LengthType.LLLVAR, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 15, 15), 11, "Test LLLVAR", "Test LLLVAR", ConditionUse.Mandatory, "000001245678950");
			de12 = new DataElement(new Attribute(new[] { AttributeFormat.NUMERIC }, LengthType.LLLVAR, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 15, 15), 12, "Test LLLVAR", "Test LLLVAR", ConditionUse.Mandatory, "AYAAAAAAAA");
			de52 = new DataElement(new Attribute(new[] { AttributeFormat.NUMERIC }, LengthType.FIXED, new[] { AttributeMask.MM, AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 8, 8), 52, "Test LLLVAR", "Test LLLVAR", ConditionUse.Mandatory, "0103090512");
		}

		[TestMethod]
		public void DataElementToString_Fixed_Must_Return_991000()
		{
			Assert.AreEqual("991000", de03.ToString());
		}

		[TestMethod]
		public void DataElementToString_LLVAR_Must_Return_102106150513()
		{
			Assert.AreEqual("102106150513", de07.ToString());
		}

		[TestMethod]
		public void DataElementToString_LLLVAR_Must_Return_015000001245678954()
		{
			Assert.AreEqual("01500000124567895A", de10.ToString());
		}

		[TestMethod]
		public void DataElement_IsValid_Must_Return_True()
		{
			Assert.IsTrue(de03.IsValid());
		}

		[TestMethod]
		public void DataElement_IsValid_Must_Return_False()
		{
			Assert.IsFalse(de10.IsValid());
		}

		[TestMethod]
		public void DataElement_NUMERIC_ALPHABETICAL_IsValid_Must_Return_True()
		{
			Assert.IsTrue(de11.IsValid());
		}

		[TestMethod]
		public void DataElement_ALPHABETICAL_Must_Return_False()
		{
			Assert.IsFalse(de12.IsValid());
		}

		[TestMethod]
		public void DataElement_Value_With_Overflow_Lenght_Must_Return_False()
		{
			Assert.IsFalse(de52.IsValid());
		}
	}
}