using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionCustomErrorResponse")]
    public class CloudfrontDistributionCustomErrorResponse : aws.Cloudfront.ICloudfrontDistributionCustomErrorResponse
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#error_code CloudfrontDistribution#error_code}.</summary>
        [JsiiProperty(name: "errorCode", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ErrorCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#error_caching_min_ttl CloudfrontDistribution#error_caching_min_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorCachingMinTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ErrorCachingMinTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#response_code CloudfrontDistribution#response_code}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responseCode", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ResponseCode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#response_page_path CloudfrontDistribution#response_page_path}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "responsePagePath", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ResponsePagePath
        {
            get;
            set;
        }
    }
}
