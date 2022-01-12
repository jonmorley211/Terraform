using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclDefaultActionAllowCustomRequestHandling), fullyQualifiedName: "aws.wafv2.Wafv2WebAclDefaultActionAllowCustomRequestHandling")]
    public interface IWafv2WebAclDefaultActionAllowCustomRequestHandling
    {
        /// <summary>insert_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#insert_header Wafv2WebAcl#insert_header}
        /// </remarks>
        [JsiiProperty(name: "insertHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllowCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2WebAclDefaultActionAllowCustomRequestHandlingInsertHeader[] InsertHeader
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclDefaultActionAllowCustomRequestHandling), fullyQualifiedName: "aws.wafv2.Wafv2WebAclDefaultActionAllowCustomRequestHandling")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclDefaultActionAllowCustomRequestHandling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>insert_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#insert_header Wafv2WebAcl#insert_header}
            /// </remarks>
            [JsiiProperty(name: "insertHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclDefaultActionAllowCustomRequestHandlingInsertHeader\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2WebAclDefaultActionAllowCustomRequestHandlingInsertHeader[] InsertHeader
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclDefaultActionAllowCustomRequestHandlingInsertHeader[]>()!;
            }
        }
    }
}
