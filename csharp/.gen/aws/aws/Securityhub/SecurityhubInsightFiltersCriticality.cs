using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Securityhub
{
    [JsiiByValue(fqn: "aws.securityhub.SecurityhubInsightFiltersCriticality")]
    public class SecurityhubInsightFiltersCriticality : aws.Securityhub.ISecurityhubInsightFiltersCriticality
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#eq SecurityhubInsight#eq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eq", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Eq
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#gte SecurityhubInsight#gte}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Gte
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/securityhub_insight#lte SecurityhubInsight#lte}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lte", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Lte
        {
            get;
            set;
        }
    }
}
