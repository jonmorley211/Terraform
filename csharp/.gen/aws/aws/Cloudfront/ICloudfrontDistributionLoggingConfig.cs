using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontDistributionLoggingConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionLoggingConfig")]
    public interface ICloudfrontDistributionLoggingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#bucket CloudfrontDistribution#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#include_cookies CloudfrontDistribution#include_cookies}.</summary>
        [JsiiProperty(name: "includeCookies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? IncludeCookies
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#prefix CloudfrontDistribution#prefix}.</summary>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontDistributionLoggingConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontDistributionLoggingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontDistributionLoggingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#bucket CloudfrontDistribution#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#include_cookies CloudfrontDistribution#include_cookies}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "includeCookies", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? IncludeCookies
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_distribution#prefix CloudfrontDistribution#prefix}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Prefix
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
