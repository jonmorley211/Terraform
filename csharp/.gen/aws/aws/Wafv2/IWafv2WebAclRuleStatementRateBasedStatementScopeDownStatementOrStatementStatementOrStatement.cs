using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatement")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatement
    {
        /// <summary>statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
        /// </remarks>
        [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}")]
        aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatementStatement[] Statement
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>statement block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#statement Wafv2WebAcl#statement}
            /// </remarks>
            [JsiiProperty(name: "statement", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatementStatement\"},\"kind\":\"array\"}}")]
            public aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatementStatement[] Statement
            {
                get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementOrStatementStatementOrStatementStatement[]>()!;
            }
        }
    }
}
