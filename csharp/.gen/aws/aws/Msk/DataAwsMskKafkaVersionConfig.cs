using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    /// <summary>AWS Managed Streaming for Kafka.</summary>
    [JsiiByValue(fqn: "aws.msk.DataAwsMskKafkaVersionConfig")]
    public class DataAwsMskKafkaVersionConfig : aws.Msk.IDataAwsMskKafkaVersionConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/msk_kafka_version#preferred_versions DataAwsMskKafkaVersion#preferred_versions}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "preferredVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? PreferredVersions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/d/msk_kafka_version#version DataAwsMskKafkaVersion#version}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Version
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
