using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleActionCount), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleActionCount")]
    public interface IWafv2WebAclRuleActionCount
    {
        /// <summary>custom_request_handling block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#custom_request_handling Wafv2WebAcl#custom_request_handling}
        /// </remarks>
        [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCountCustomRequestHandling\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandling? CustomRequestHandling
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleActionCount), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleActionCount")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleActionCount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_request_handling block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#custom_request_handling Wafv2WebAcl#custom_request_handling}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customRequestHandling", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionCountCustomRequestHandling\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandling? CustomRequestHandling
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionCountCustomRequestHandling?>();
            }
        }
    }
}
