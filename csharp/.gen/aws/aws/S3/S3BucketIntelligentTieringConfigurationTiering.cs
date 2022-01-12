using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3BucketIntelligentTieringConfigurationTiering")]
    public class S3BucketIntelligentTieringConfigurationTiering : aws.S3.IS3BucketIntelligentTieringConfigurationTiering
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_intelligent_tiering_configuration#access_tier S3BucketIntelligentTieringConfiguration#access_tier}.</summary>
        [JsiiProperty(name: "accessTier", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AccessTier
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_intelligent_tiering_configuration#days S3BucketIntelligentTieringConfiguration#days}.</summary>
        [JsiiProperty(name: "days", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Days
        {
            get;
            set;
        }
    }
}
