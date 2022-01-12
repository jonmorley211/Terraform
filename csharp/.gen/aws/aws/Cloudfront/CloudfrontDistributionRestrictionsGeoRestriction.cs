using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontDistributionRestrictionsGeoRestriction")]
    public class CloudfrontDistributionRestrictionsGeoRestriction : aws.Cloudfront.ICloudfrontDistributionRestrictionsGeoRestriction
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#restriction_type CloudfrontDistribution#restriction_type}.</summary>
        [JsiiProperty(name: "restrictionType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string RestrictionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#locations CloudfrontDistribution#locations}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "locations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Locations
        {
            get;
            set;
        }
    }
}
