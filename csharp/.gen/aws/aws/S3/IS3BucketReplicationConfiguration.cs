using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3BucketReplicationConfiguration), fullyQualifiedName: "aws.s3.S3BucketReplicationConfiguration")]
    public interface IS3BucketReplicationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#role S3Bucket#role}.</summary>
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
        string Role
        {
            get;
        }

        /// <summary>rules block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#rules S3Bucket#rules}
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRules\"},\"kind\":\"array\"}}")]
        aws.S3.IS3BucketReplicationConfigurationRules[] Rules
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3BucketReplicationConfiguration), fullyQualifiedName: "aws.s3.S3BucketReplicationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketReplicationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#role S3Bucket#role}.</summary>
            [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}")]
            public string Role
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>rules block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket#rules S3Bucket#rules}
            /// </remarks>
            [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketReplicationConfigurationRules\"},\"kind\":\"array\"}}")]
            public aws.S3.IS3BucketReplicationConfigurationRules[] Rules
            {
                get => GetInstanceProperty<aws.S3.IS3BucketReplicationConfigurationRules[]>()!;
            }
        }
    }
}
