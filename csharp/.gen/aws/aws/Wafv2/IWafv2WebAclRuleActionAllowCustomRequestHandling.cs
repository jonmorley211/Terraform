using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleActionAllowCustomRequestHandling), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleActionAllowCustomRequestHandling")]
    public interface IWafv2WebAclRuleActionAllowCustomRequestHandling
    {
        /// <summary>insert_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#insert_header Wafv2WebAcl#insert_header}
        /// </remarks>
        [JsiiProperty(name: "insertHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionAllowCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2WebAclRuleActionAllowCustomRequestHandlingInsertHeader[] InsertHeader
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleActionAllowCustomRequestHandling), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleActionAllowCustomRequestHandling")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleActionAllowCustomRequestHandling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>insert_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#insert_header Wafv2WebAcl#insert_header}
            /// </remarks>
            [JsiiProperty(name: "insertHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionAllowCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2WebAclRuleActionAllowCustomRequestHandlingInsertHeader[] InsertHeader
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionAllowCustomRequestHandlingInsertHeader[]>()!;
            }
        }
    }
}
