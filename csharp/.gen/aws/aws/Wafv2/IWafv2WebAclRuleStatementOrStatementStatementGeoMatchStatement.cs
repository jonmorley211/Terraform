using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement")]
    public interface IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#country_codes Wafv2WebAcl#country_codes}.</summary>
        [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] CountryCodes
        {
            get;
        }

        /// <summary>forwarded_ip_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#forwarded_ip_config Wafv2WebAcl#forwarded_ip_config}
        /// </remarks>
        [JsiiProperty(name: "forwardedIpConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementGeoMatchStatementForwardedIpConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatementForwardedIpConfig? ForwardedIpConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#country_codes Wafv2WebAcl#country_codes}.</summary>
            [JsiiProperty(name: "countryCodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] CountryCodes
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>forwarded_ip_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#forwarded_ip_config Wafv2WebAcl#forwarded_ip_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "forwardedIpConfig", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementGeoMatchStatementForwardedIpConfig\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatementForwardedIpConfig? ForwardedIpConfig
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementGeoMatchStatementForwardedIpConfig?>();
            }
        }
    }
}