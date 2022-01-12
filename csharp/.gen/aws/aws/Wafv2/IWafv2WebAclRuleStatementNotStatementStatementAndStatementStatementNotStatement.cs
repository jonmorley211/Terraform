using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatement")]
    public interface IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatement
    {
        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatement[] Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
            /// </remarks>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatement\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatement[] Statement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementNotStatementStatementAndStatementStatementNotStatementStatement[]>()!;
            }
        }
    }
}
