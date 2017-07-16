using ISONET.Domain.Entities;
using ISONET.Domain.Interfaces.Entities;
using ISONET.Domain.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ISONET.Test.Domain
{
    [TestClass]
    public class BitMapValidationTest
    {
        private IMessage msg0800;

        [TestInitialize]
        public void TestInitialize()
        {
            msg0800 = new Message(0800, @"Logon",

                                         new List<IDataElement>
                                         {
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric}, LengthType.FIXED, new[] {AttributeMask.NoMask }, 6), 3,@"Código de Processamento",@"Código de Processamento",ConditionUse.Mandatory, @"991000"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric}, LengthType.FIXED, new[] {AttributeMask.MM,AttributeMask.DD, AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 10),7,@"Data e Hora GMT",@"Data e Hora GMT", ConditionUse.Mandatory, @"0629111510"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric}, LengthType.FIXED, new[] {AttributeMask.NoMask}, 6),11,@"NSU da Captura",@"NSU da Captura", ConditionUse.Mandatory,@"123456"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric}, LengthType.FIXED, new[] {AttributeMask.hh, AttributeMask.mm, AttributeMask.ss }, 6),12,@"Hora Local",@"Hora Local",ConditionUse.Mandatory,@"111510"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric}, LengthType.FIXED, new[] {AttributeMask.MM,AttributeMask.DD  }, 4),13,@"Data Local",@"Data Loca", ConditionUse.Mandatory, @"0629"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric,  AttributeFormat.Alphabetical, AttributeFormat.Special}, LengthType.FIXED, new[] {AttributeMask.NoMask }, 3), 40,@"Versão da Mensagem",@"Versão da Mensagem",ConditionUse.Mandatory, @"001"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric,  AttributeFormat.Alphabetical, AttributeFormat.Special}, LengthType.FIXED, new[] {AttributeMask.NoMask }, 8), 41,@"Código do Terminal",@"Código do Terminal",ConditionUse.Mandatory, @"00000005"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric,  AttributeFormat.Alphabetical, AttributeFormat.Special}, LengthType.FIXED, new[] {AttributeMask.NoMask }, 15), 42,@"Código do Estabelecimento",@"Código do Estabelecimento", ConditionUse.Mandatory,@"000000000012345"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric,  AttributeFormat.Alphabetical, AttributeFormat.Special}, LengthType.LLLVAR, new[] {AttributeMask.NoMask }, 8), 58,@"Código do Terminal TEF Virtualizado",@"Código do Terminal TEF Virtualizado",ConditionUse.Mandatory, @"T0000124"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric,  AttributeFormat.Alphabetical, AttributeFormat.Special}, LengthType.LLLVAR, new[] {AttributeMask.NoMask }, 999, 15), 59,@"Envio de dados adicionais técnicos",@"Envio de dados adicionais técnicos" ,ConditionUse.Mandatory,@"000124578965412"),
                                            new DataElement(new DataElementAttribute(new[] {AttributeFormat.Numeric}, LengthType.LLLVAR, new[] {AttributeMask.NoMask }, 999, 3), 60,@"Versão das tabelas",@"Versão das tabelas",ConditionUse.Mandatory, @"005")
                                         });
        }

        [TestMethod]
        public void BitMapValidationTest_Must_Be_True() => Assert.IsTrue(msg0800.BitMapIsValid());
    }
}