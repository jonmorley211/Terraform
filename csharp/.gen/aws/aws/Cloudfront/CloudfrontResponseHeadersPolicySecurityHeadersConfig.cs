using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfig")]
    public class CloudfrontResponseHeadersPolicySecurityHeadersConfig : aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfig
    {
        /// <summary>content_security_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#content_security_policy CloudfrontResponseHeadersPolicy#content_security_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentSecurityPolicy", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicy
        {
            get;
            set;
        }

        /// <summary>content_type_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#content_type_options CloudfrontResponseHeadersPolicy#content_type_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "contentTypeOptions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions? ContentTypeOptions
        {
            get;
            set;
        }

        /// <summary>frame_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#frame_options CloudfrontResponseHeadersPolicy#frame_options}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "frameOptions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions? FrameOptions
        {
            get;
            set;
        }

        /// <summary>referrer_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#referrer_policy CloudfrontResponseHeadersPolicy#referrer_policy}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "referrerPolicy", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy? ReferrerPolicy
        {
            get;
            set;
        }

        /// <summary>strict_transport_security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#strict_transport_security CloudfrontResponseHeadersPolicy#strict_transport_security}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "strictTransportSecurity", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurity
        {
            get;
            set;
        }

        /// <summary>xss_protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#xss_protection CloudfrontResponseHeadersPolicy#xss_protection}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "xssProtection", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection? XssProtection
        {
            get;
            set;
        }
    }
}
