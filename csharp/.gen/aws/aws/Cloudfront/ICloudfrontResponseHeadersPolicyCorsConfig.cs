using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontResponseHeadersPolicyCorsConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfig")]
    public interface ICloudfrontResponseHeadersPolicyCorsConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_credentials CloudfrontResponseHeadersPolicy#access_control_allow_credentials}.</summary>
        [JsiiProperty(name: "accessControlAllowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object AccessControlAllowCredentials
        {
            get;
        }

        /// <summary>access_control_allow_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_headers CloudfrontResponseHeadersPolicy#access_control_allow_headers}
        /// </remarks>
        [JsiiProperty(name: "accessControlAllowHeaders", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders\"}")]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders AccessControlAllowHeaders
        {
            get;
        }

        /// <summary>access_control_allow_methods block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_methods CloudfrontResponseHeadersPolicy#access_control_allow_methods}
        /// </remarks>
        [JsiiProperty(name: "accessControlAllowMethods", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods\"}")]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods AccessControlAllowMethods
        {
            get;
        }

        /// <summary>access_control_allow_origins block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_origins CloudfrontResponseHeadersPolicy#access_control_allow_origins}
        /// </remarks>
        [JsiiProperty(name: "accessControlAllowOrigins", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}")]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins AccessControlAllowOrigins
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#origin_override CloudfrontResponseHeadersPolicy#origin_override}.</summary>
        [JsiiProperty(name: "originOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object OriginOverride
        {
            get;
        }

        /// <summary>access_control_expose_headers block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_expose_headers CloudfrontResponseHeadersPolicy#access_control_expose_headers}
        /// </remarks>
        [JsiiProperty(name: "accessControlExposeHeaders", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders? AccessControlExposeHeaders
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_max_age_sec CloudfrontResponseHeadersPolicy#access_control_max_age_sec}.</summary>
        [JsiiProperty(name: "accessControlMaxAgeSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? AccessControlMaxAgeSec
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontResponseHeadersPolicyCorsConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_credentials CloudfrontResponseHeadersPolicy#access_control_allow_credentials}.</summary>
            [JsiiProperty(name: "accessControlAllowCredentials", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object AccessControlAllowCredentials
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>access_control_allow_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_headers CloudfrontResponseHeadersPolicy#access_control_allow_headers}
            /// </remarks>
            [JsiiProperty(name: "accessControlAllowHeaders", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders\"}")]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders AccessControlAllowHeaders
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowHeaders>()!;
            }

            /// <summary>access_control_allow_methods block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_methods CloudfrontResponseHeadersPolicy#access_control_allow_methods}
            /// </remarks>
            [JsiiProperty(name: "accessControlAllowMethods", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods\"}")]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods AccessControlAllowMethods
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowMethods>()!;
            }

            /// <summary>access_control_allow_origins block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_allow_origins CloudfrontResponseHeadersPolicy#access_control_allow_origins}
            /// </remarks>
            [JsiiProperty(name: "accessControlAllowOrigins", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins\"}")]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins AccessControlAllowOrigins
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlAllowOrigins>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#origin_override CloudfrontResponseHeadersPolicy#origin_override}.</summary>
            [JsiiProperty(name: "originOverride", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object OriginOverride
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>access_control_expose_headers block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_expose_headers CloudfrontResponseHeadersPolicy#access_control_expose_headers}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessControlExposeHeaders", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders? AccessControlExposeHeaders
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontResponseHeadersPolicyCorsConfigAccessControlExposeHeaders?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_response_headers_policy#access_control_max_age_sec CloudfrontResponseHeadersPolicy#access_control_max_age_sec}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accessControlMaxAgeSec", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? AccessControlMaxAgeSec
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
