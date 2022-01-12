using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiByValue(fqn: "aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatch")]
    public class Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatch : aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatch
    {
        /// <summary>all_query_arguments block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#all_query_arguments Wafv2WebAcl#all_query_arguments}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allQueryArguments", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchAllQueryArguments? AllQueryArguments
        {
            get;
            set;
        }

        /// <summary>body block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#body Wafv2WebAcl#body}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "body", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchBody\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchBody? Body
        {
            get;
            set;
        }

        /// <summary>method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#method Wafv2WebAcl#method}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "method", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchMethod\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchMethod? Method
        {
            get;
            set;
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#query_string Wafv2WebAcl#query_string}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryString", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchQueryString\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchQueryString? QueryString
        {
            get;
            set;
        }

        /// <summary>single_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#single_header Wafv2WebAcl#single_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleHeader", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleHeader? SingleHeader
        {
            get;
            set;
        }

        /// <summary>single_query_argument block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#single_query_argument Wafv2WebAcl#single_query_argument}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singleQueryArgument", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchSingleQueryArgument? SingleQueryArgument
        {
            get;
            set;
        }

        /// <summary>uri_path block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/wafv2_web_acl#uri_path Wafv2WebAcl#uri_path}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uriPath", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchUriPath\"}", isOptional: true, isOverride: true)]
        public aws.Wafv2.IWafv2WebAclRuleStatementOrStatementStatementSizeConstraintStatementFieldToMatchUriPath? UriPath
        {
            get;
            set;
        }
    }
}
