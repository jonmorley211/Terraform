using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleActionBlock), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleActionBlock")]
    public interface IWafv2WebAclRuleActionBlock
    {
        /// <summary>custom_response block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#custom_response Wafv2WebAcl#custom_response}
        /// </remarks>
        [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionBlockCustomResponse\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Wafv2.IWafv2WebAclRuleActionBlockCustomResponse? CustomResponse
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleActionBlock), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleActionBlock")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleActionBlock
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>custom_response block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#custom_response Wafv2WebAcl#custom_response}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleActionBlockCustomResponse\"}", isOptional: true)]
            public aws.Wafv2.IWafv2WebAclRuleActionBlockCustomResponse? CustomResponse
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleActionBlockCustomResponse?>();
            }
        }
    }
}
