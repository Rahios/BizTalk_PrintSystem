namespace BizTalkPrintSystem.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.AddAmount", typeof(global::BizTalkPrintSystem.Schemas.AddAmount))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.AddAmountByUsername_SOAP", typeof(global::BizTalkPrintSystem.Schemas.AddAmountByUsername_SOAP))]
    public sealed class AddAmount_To_AddAmountSOAP : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns=""http://tempuri.org/"" xmlns:ns0=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:s0=""http://BizTalkPrintSystem.Schemas.AddAmount"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddAmount"" />
  </xsl:template>
  <xsl:template match=""/s0:AddAmount"">
    <ns0:Envelope>
      <ns0:Body>
        <ns:AddAmountByUsername>
          <ns:Username>
            <xsl:value-of select=""UserName/text()"" />
          </ns:Username>
          <ns:QuotaCHF>
            <xsl:value-of select=""Amount/text()"" />
          </ns:QuotaCHF>
        </ns:AddAmountByUsername>
      </ns0:Body>
    </ns0:Envelope>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkPrintSystem.Schemas.AddAmount";
        
        private const global::BizTalkPrintSystem.Schemas.AddAmount _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkPrintSystem.Schemas.AddAmountByUsername_SOAP";
        
        private const global::BizTalkPrintSystem.Schemas.AddAmountByUsername_SOAP _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BizTalkPrintSystem.Schemas.AddAmount";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkPrintSystem.Schemas.AddAmountByUsername_SOAP";
                return _TrgSchemas;
            }
        }
    }
}
