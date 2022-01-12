using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfig")]
    public class CloudfrontOriginRequestPolicyHeadersConfig : aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#header_behavior CloudfrontOriginRequestPolicy#header_behavior}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "headerBehavior", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? HeaderBehavior
        {
            get;
            set;
        }

        /// <summary>headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#headers CloudfrontOriginRequestPolicy#headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "headers", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyHeadersConfigHeaders\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontOriginRequestPolicyHeadersConfigHeaders? Headers
        {
            get;
            set;
        }
    }
}
