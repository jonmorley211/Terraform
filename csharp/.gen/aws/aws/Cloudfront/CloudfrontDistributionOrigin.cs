using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionOrigin")]
    public class CloudfrontDistributionOrigin : aws.Cloudfront.ICloudfrontDistributionOrigin
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#domain_name CloudfrontDistribution#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_id CloudfrontDistribution#origin_id}.</summary>
        [JsiiProperty(name: "originId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string OriginId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#connection_attempts CloudfrontDistribution#connection_attempts}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionAttempts", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ConnectionAttempts
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#connection_timeout CloudfrontDistribution#connection_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "connectionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ConnectionTimeout
        {
            get;
            set;
        }

        /// <summary>custom_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_header CloudfrontDistribution#custom_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customHeader", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginCustomHeader\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontDistributionOriginCustomHeader[]? CustomHeader
        {
            get;
            set;
        }

        /// <summary>custom_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#custom_origin_config CloudfrontDistribution#custom_origin_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "customOriginConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginCustomOriginConfig\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontDistributionOriginCustomOriginConfig? CustomOriginConfig
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_path CloudfrontDistribution#origin_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "originPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OriginPath
        {
            get;
            set;
        }

        /// <summary>origin_shield block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#origin_shield CloudfrontDistribution#origin_shield}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "originShield", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginOriginShield\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontDistributionOriginOriginShield? OriginShield
        {
            get;
            set;
        }

        /// <summary>s3_origin_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#s3_origin_config CloudfrontDistribution#s3_origin_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "s3OriginConfig", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontDistributionOriginS3OriginConfig\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontDistributionOriginS3OriginConfig? S3OriginConfig
        {
            get;
            set;
        }
    }
}
