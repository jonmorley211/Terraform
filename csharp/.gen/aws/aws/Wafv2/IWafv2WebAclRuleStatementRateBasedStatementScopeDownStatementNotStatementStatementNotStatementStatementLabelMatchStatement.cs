using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiInterface(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatementLabelMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatementLabelMatchStatement")]
    public interface IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatementLabelMatchStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#key Wafv2WebAcl#key}.</summary>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#scope Wafv2WebAcl#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatementLabelMatchStatement), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatementLabelMatchStatement")]
        internal sealed class _Proxy : DeputyBase, aws.Wafv2.IWafv2WebAclRuleStatementRateBasedStatementScopeDownStatementNotStatementStatementNotStatementStatementLabelMatchStatement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#key Wafv2WebAcl#key}.</summary>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#scope Wafv2WebAcl#scope}.</summary>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
