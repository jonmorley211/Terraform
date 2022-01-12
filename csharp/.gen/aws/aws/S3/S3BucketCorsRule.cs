using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketCorsRule")]
    public class S3BucketCorsRule : aws.S3.IS3BucketCorsRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#allowed_methods S3Bucket#allowed_methods}.</summary>
        [JsiiProperty(name: "allowedMethods", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] AllowedMethods
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#allowed_origins S3Bucket#allowed_origins}.</summary>
        [JsiiProperty(name: "allowedOrigins", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] AllowedOrigins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#allowed_headers S3Bucket#allowed_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AllowedHeaders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#expose_headers S3Bucket#expose_headers}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "exposeHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? ExposeHeaders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#max_age_seconds S3Bucket#max_age_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxAgeSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxAgeSeconds
        {
            get;
            set;
        }
    }
}
