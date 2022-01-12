using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontResponseHeadersPolicySecurityHeadersConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfig")]
    public interface ICloudfrontResponseHeadersPolicySecurityHeadersConfig
    {
        /// <summary>content_security_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#content_security_policy CloudfrontResponseHeadersPolicy#content_security_policy}
        /// </remarks>
        [JsiiProperty(name: "contentSecurityPolicy", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>content_type_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#content_type_options CloudfrontResponseHeadersPolicy#content_type_options}
        /// </remarks>
        [JsiiProperty(name: "contentTypeOptions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions? ContentTypeOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>frame_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#frame_options CloudfrontResponseHeadersPolicy#frame_options}
        /// </remarks>
        [JsiiProperty(name: "frameOptions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions? FrameOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>referrer_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#referrer_policy CloudfrontResponseHeadersPolicy#referrer_policy}
        /// </remarks>
        [JsiiProperty(name: "referrerPolicy", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy? ReferrerPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>strict_transport_security block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#strict_transport_security CloudfrontResponseHeadersPolicy#strict_transport_security}
        /// </remarks>
        [JsiiProperty(name: "strictTransportSecurity", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurity
        {
            get
            {
                return null;
            }
        }

        /// <summary>xss_protection block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#xss_protection CloudfrontResponseHeadersPolicy#xss_protection}
        /// </remarks>
        [JsiiProperty(name: "xssProtection", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection? XssProtection
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontResponseHeadersPolicySecurityHeadersConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>content_security_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#content_security_policy CloudfrontResponseHeadersPolicy#content_security_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentSecurityPolicy", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy? ContentSecurityPolicy
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentSecurityPolicy?>();
            }

            /// <summary>content_type_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#content_type_options CloudfrontResponseHeadersPolicy#content_type_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "contentTypeOptions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions? ContentTypeOptions
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigContentTypeOptions?>();
            }

            /// <summary>frame_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#frame_options CloudfrontResponseHeadersPolicy#frame_options}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "frameOptions", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions? FrameOptions
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigFrameOptions?>();
            }

            /// <summary>referrer_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#referrer_policy CloudfrontResponseHeadersPolicy#referrer_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "referrerPolicy", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy? ReferrerPolicy
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigReferrerPolicy?>();
            }

            /// <summary>strict_transport_security block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#strict_transport_security CloudfrontResponseHeadersPolicy#strict_transport_security}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "strictTransportSecurity", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity? StrictTransportSecurity
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigStrictTransportSecurity?>();
            }

            /// <summary>xss_protection block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#xss_protection CloudfrontResponseHeadersPolicy#xss_protection}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "xssProtection", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection? XssProtection
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicySecurityHeadersConfigXssProtection?>();
            }
        }
    }
}
