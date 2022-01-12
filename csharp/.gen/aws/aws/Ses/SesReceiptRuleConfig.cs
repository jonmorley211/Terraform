using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ses
{
    #pragma warning disable CS8618

    /// <summary>AWS Simple Email Service.</summary>
    [JsiiByValue(fqn: "aws.ses.SesReceiptRuleConfig")]
    public class SesReceiptRuleConfig : aws.Ses.ISesReceiptRuleConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#name SesReceiptRule#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#rule_set_name SesReceiptRule#rule_set_name}.</summary>
        [JsiiProperty(name: "ruleSetName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RuleSetName
        {
            get;
            set;
        }

        /// <summary>add_header_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#add_header_action SesReceiptRule#add_header_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "addHeaderAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleAddHeaderAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ses.ISesReceiptRuleAddHeaderAction[]? AddHeaderAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#after SesReceiptRule#after}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "after", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? After
        {
            get;
            set;
        }

        /// <summary>bounce_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#bounce_action SesReceiptRule#bounce_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bounceAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleBounceAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ses.ISesReceiptRuleBounceAction[]? BounceAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#enabled SesReceiptRule#enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Enabled
        {
            get;
            set;
        }

        /// <summary>lambda_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#lambda_action SesReceiptRule#lambda_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleLambdaAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ses.ISesReceiptRuleLambdaAction[]? LambdaAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#recipients SesReceiptRule#recipients}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "recipients", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Recipients
        {
            get;
            set;
        }

        /// <summary>s3_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#s3_action SesReceiptRule#s3_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3Action", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleS3Action\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ses.ISesReceiptRuleS3Action[]? S3Action
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#scan_enabled SesReceiptRule#scan_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scanEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? ScanEnabled
        {
            get;
            set;
        }

        /// <summary>sns_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#sns_action SesReceiptRule#sns_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "snsAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleSnsAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ses.ISesReceiptRuleSnsAction[]? SnsAction
        {
            get;
            set;
        }

        /// <summary>stop_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#stop_action SesReceiptRule#stop_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stopAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleStopAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ses.ISesReceiptRuleStopAction[]? StopAction
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#tls_policy SesReceiptRule#tls_policy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tlsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? TlsPolicy
        {
            get;
            set;
        }

        /// <summary>workmail_action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/ses_receipt_rule#workmail_action SesReceiptRule#workmail_action}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "workmailAction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ses.SesReceiptRuleWorkmailAction\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Ses.ISesReceiptRuleWorkmailAction[]? WorkmailAction
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
