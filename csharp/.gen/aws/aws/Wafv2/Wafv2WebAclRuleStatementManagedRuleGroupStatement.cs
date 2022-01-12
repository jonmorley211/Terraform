using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatement")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatement : aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatement
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#name Wafv2WebAcl#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#vendor_name Wafv2WebAcl#vendor_name}.</summary>
        [JsiiProperty(name: "vendorName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string VendorName
        {
            get;
            set;
        }

        /// <summary>excluded_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#excluded_rule Wafv2WebAcl#excluded_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludedRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementExcludedRule[]? ExcludedRule
        {
            get;
            set;
        }

        /// <summary>scope_down_statement block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#scope_down_statement Wafv2WebAcl#scope_down_statement}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scopeDownStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatement\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatement? ScopeDownStatement
        {
            get;
            set;
        }
    }
}
