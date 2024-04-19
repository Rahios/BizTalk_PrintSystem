namespace BizTalkPrintSystem.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://schemas.xmlsoap.org/soap/envelope/",@"Envelope")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Envelope"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.AddAmountByUsername_SOAP1", typeof(global::BizTalkPrintSystem.Schemas.AddAmountByUsername_SOAP1))]
    public sealed class AddAmountByUsername_SOAP : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:ns=""http://tempuri.org/"" xmlns:soapenv=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" targetNamespace=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:import schemaLocation=""BizTalkPrintSystem.Schemas.AddAmountByUsername_SOAP1"" namespace=""http://tempuri.org/"" />
  <xs:annotation>
    <xs:appinfo>
      <references xmlns=""http://schemas.microsoft.com/BizTalk/2003"">
        <reference targetNamespace=""http://tempuri.org/"" />
      </references>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Envelope"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Header"" type=""xs:anyType"" />
        <xs:element name=""Body"">
          <xs:complexType>
            <xs:sequence>
              <xs:element ref=""ns:AddAmountByUsername"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public AddAmountByUsername_SOAP() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Envelope";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
