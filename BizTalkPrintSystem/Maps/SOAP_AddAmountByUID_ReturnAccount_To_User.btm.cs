namespace BizTalkPrintSystem.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+AddAmountByUIDResponse", typeof(global::BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org.AddAmountByUIDResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.User", typeof(global::BizTalkPrintSystem.Schemas.User))]
    public sealed class SOAP_AddAmountByUID_ReturnAccount_To_User : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:s0=""http://schemas.datacontract.org/2004/07/DTO"" xmlns:s1=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:AddAmountByUIDResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:AddAmountByUIDResponse"">
    <User>
      <xsl:if test=""s1:AddAmountByUIDResult/s0:Username"">
        <Username>
          <xsl:value-of select=""s1:AddAmountByUIDResult/s0:Username/text()"" />
        </Username>
      </xsl:if>
      <xsl:if test=""s1:AddAmountByUIDResult/s0:QuotaFeuilles"">
        <Quota>
          <xsl:value-of select=""s1:AddAmountByUIDResult/s0:QuotaFeuilles/text()"" />
        </Quota>
      </xsl:if>
    </User>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+AddAmountByUIDResponse";
        
        private const global::BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org.AddAmountByUIDResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BizTalkPrintSystem.Schemas.User";
        
        private const global::BizTalkPrintSystem.Schemas.User _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkPrintSystem.Schemas.ServiceAccount_tempuri_org+AddAmountByUIDResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BizTalkPrintSystem.Schemas.User";
                return _TrgSchemas;
            }
        }
    }
}
