namespace BizTalkPrintSystem.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalkPrintSystem.Schemas.auth",@"Auth")]
    [Microsoft.XLANGs.BaseTypes.PropertyAttribute(typeof(global::BizTalkPrintSystem.PropertySchema.CorrelationId), XPath = @"/*[local-name()='Auth' and namespace-uri()='http://BizTalkPrintSystem.Schemas.auth']/*[local-name()='CorrelationId' and namespace-uri()='']", XsdType = @"string")]
    [Microsoft.XLANGs.BaseTypes.DistinguishedFieldAttribute(typeof(System.String), "CorrelationId", XPath = @"/*[local-name()='Auth' and namespace-uri()='http://BizTalkPrintSystem.Schemas.auth']/*[local-name()='CorrelationId' and namespace-uri()='']", XsdType = @"string")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Auth"})]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.PropertySchema.PropertySchema", typeof(global::BizTalkPrintSystem.PropertySchema.PropertySchema))]
    public sealed class Auth : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalkPrintSystem.Schemas.auth"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" xmlns:ns0=""https://BizTalkPrintSystem.PropertySchema"" targetNamespace=""http://BizTalkPrintSystem.Schemas.auth"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:annotation>
    <xs:appinfo>
      <b:imports>
        <b:namespace prefix=""ns0"" uri=""https://BizTalkPrintSystem.PropertySchema"" location=""BizTalkPrintSystem.PropertySchema.PropertySchema"" />
      </b:imports>
    </xs:appinfo>
  </xs:annotation>
  <xs:element name=""Auth"">
    <xs:annotation>
      <xs:appinfo>
        <b:properties>
          <b:property name=""ns0:CorrelationId"" xpath=""/*[local-name()='Auth' and namespace-uri()='http://BizTalkPrintSystem.Schemas.auth']/*[local-name()='CorrelationId' and namespace-uri()='']"" />
          <b:property distinguished=""true"" xpath=""/*[local-name()='Auth' and namespace-uri()='http://BizTalkPrintSystem.Schemas.auth']/*[local-name()='CorrelationId' and namespace-uri()='']"" />
        </b:properties>
      </xs:appinfo>
    </xs:annotation>
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""username"" type=""xs:string"" />
        <xs:element name=""password"" type=""xs:string"" />
        <xs:element name=""CorrelationId"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Auth() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Auth";
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
