using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfig")]
    public class CloudfrontOriginRequestPolicyQueryStringsConfig : aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#query_string_behavior CloudfrontOriginRequestPolicy#query_string_behavior}.</summary>
        [JsiiProperty(name: "queryStringBehavior", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string QueryStringBehavior
        {
            get;
            set;
        }

        /// <summary>query_strings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#query_strings CloudfrontOriginRequestPolicy#query_strings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryStrings", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontOriginRequestPolicyQueryStringsConfigQueryStrings? QueryStrings
        {
            get;
            set;
        }
    }
}
