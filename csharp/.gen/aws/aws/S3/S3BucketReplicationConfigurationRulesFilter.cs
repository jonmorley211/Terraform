using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiByValue(fqn: "aws.s3.S3BucketReplicationConfigurationRulesFilter")]
    public class S3BucketReplicationConfigurationRulesFilter : aws.S3.IS3BucketReplicationConfigurationRulesFilter
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#prefix S3Bucket#prefix}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#tags S3Bucket#tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? Tags
        {
            get;
            set;
        }
    }
}
