namespace BizTalkPrintSystem.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.AddAmount_UID", typeof(global::BizTalkPrintSystem.Schemas.AddAmount_UID))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+AddAmountByUID", typeof(global::BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org.AddAmountByUID))]
    public sealed class AddAmount_To_AddAmountByUIDSOAP : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://tempuri.org/"" xmlns:ns1=""http://schemas.datacontract.org/2004/07/DTO"" xmlns:s0=""http://BizTalkPrintSystem.Schemas.AddAmount_UID"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:AddAmount"" />
  </xsl:template>
  <xsl:template match=""/s0:AddAmount"">
    <ns0:AddAmountByUID>
      <ns0:UID>
        <xsl:value-of select=""UID/text()"" />
      </ns0:UID>
      <ns0:QuotaCHF>
        <xsl:value-of select=""Amount/text()"" />
      </ns0:QuotaCHF>
    </ns0:AddAmountByUID>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkPrintSystem.Schemas.AddAmount_UID";
        
        private const global::BizTalkPrintSystem.Schemas.AddAmount_UID _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+AddAmountByUID";
        
        private const global::BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org.AddAmountByUID _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkPrintSystem.Schemas.AddAmount_UID";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+AddAmountByUID";
                return _TrgSchemas;
            }
        }
    }
}
