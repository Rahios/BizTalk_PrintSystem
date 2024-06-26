namespace BizTalkPrintSystem.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.SOAP_Account", typeof(global::BizTalkPrintSystem.Schemas.SOAP_Account))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BizTalkPrintSystem.Schemas.User", typeof(global::BizTalkPrintSystem.Schemas.User))]
    public sealed class SOAP_Account_To_User : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s1 s0"" version=""1.0"" xmlns:s1=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:s0=""http://tempuri.org/"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:Envelope"" />
  </xsl:template>
  <xsl:template match=""/s1:Envelope"">
    <User>
      <Username>
        <xsl:value-of select=""s1:Body/s0:AddUserResponse/s0:Account/s0:Username/text()"" />
      </Username>
      <Quota>
        <xsl:value-of select=""s1:Body/s0:AddUserResponse/s0:Account/s0:QuotaFeuilles/text()"" />
      </Quota>
    </User>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BizTalkPrintSystem.Schemas.SOAP_Account";
        
        private const global::BizTalkPrintSystem.Schemas.SOAP_Account _srcSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"BizTalkPrintSystem.Schemas.SOAP_Account";
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
