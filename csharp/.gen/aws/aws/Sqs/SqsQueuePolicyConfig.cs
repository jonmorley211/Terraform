using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sqs
{
    #pragma warning disable CS8618

    /// <summary>AWS Simple Queue Service.</summary>
    [JsiiByValue(fqn: "aws.sqs.SqsQueuePolicyConfig")]
    public class SqsQueuePolicyConfig : aws.Sqs.ISqsQueuePolicyConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue_policy#policy SqsQueuePolicy#policy}.</summary>
        [JsiiProperty(name: "policy", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Policy
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sqs_queue_policy#queue_url SqsQueuePolicy#queue_url}.</summary>
        [JsiiProperty(name: "queueUrl", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string QueueUrl
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
