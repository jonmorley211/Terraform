using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfig")]
    public class CloudfrontResponseHeadersPolicyCorsConfig : aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_credentials CloudfrontResponseHeadersPolicy#access_control_allow_credentials}.</summary>
        [JsiiProperty(name: "accessControlAllowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object AccessControlAllowCredentials
        {
            get;
            set;
        }

        /// <summary>access_control_allow_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_headers CloudfrontResponseHeadersPolicy#access_control_allow_headers}
        /// </remarks>
        [JsiiProperty(name: "accessControlAllowHeaders", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders AccessControlAllowHeaders
        {
            get;
            set;
        }

        /// <summary>access_control_allow_methods block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_methods CloudfrontResponseHeadersPolicy#access_control_allow_methods}
        /// </remarks>
        [JsiiProperty(name: "accessControlAllowMethods", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods AccessControlAllowMethods
        {
            get;
            set;
        }

        /// <summary>access_control_allow_origins block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_origins CloudfrontResponseHeadersPolicy#access_control_allow_origins}
        /// </remarks>
        [JsiiProperty(name: "accessControlAllowOrigins", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins AccessControlAllowOrigins
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#origin_override CloudfrontResponseHeadersPolicy#origin_override}.</summary>
        [JsiiProperty(name: "originOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object OriginOverride
        {
            get;
            set;
        }

        /// <summary>access_control_expose_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_expose_headers CloudfrontResponseHeadersPolicy#access_control_expose_headers}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessControlExposeHeaders", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders? AccessControlExposeHeaders
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_max_age_sec CloudfrontResponseHeadersPolicy#access_control_max_age_sec}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accessControlMaxAgeSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AccessControlMaxAgeSec
        {
            get;
            set;
        }
    }
}
