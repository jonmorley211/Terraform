using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementGeoMatchStatement")]
    public class Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementGeoMatchStatement : aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementGeoMatchStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#country_codes Wafv2WebAcl#country_codes}.</summary>
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] CountryCodes
        {
            get;
            set;
        }

        /// <summary>forwarded_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#forwarded_ip_config Wafv2WebAcl#forwarded_ip_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "forwardedIpConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementGeoMatchStatementForwardedIpConfig\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementNotStatementStatementGeoMatchStatementForwardedIpConfig? ForwardedIpConfig
        {
            get;
            set;
        }
    }
}
