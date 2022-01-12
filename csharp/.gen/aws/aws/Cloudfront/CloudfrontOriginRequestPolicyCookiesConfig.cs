using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfig")]
    public class CloudfrontOriginRequestPolicyCookiesConfig : aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#cookie_behavior CloudfrontOriginRequestPolicy#cookie_behavior}.</summary>
        [JsiiProperty(name: "cookieBehavior", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CookieBehavior
        {
            get;
            set;
        }

        /// <summary>cookies block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_origin_request_policy#cookies CloudfrontOriginRequestPolicy#cookies}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "cookies", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontOriginRequestPolicyCookiesConfigCookies\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontOriginRequestPolicyCookiesConfigCookies? Cookies
        {
            get;
            set;
        }
    }
}
