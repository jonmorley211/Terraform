using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    /// <summary>AWS Simple Storage Service.</summary>
    [JsiiInterface(nativeType: typeof(IS3BucketNotificationConfig), fullyQualifiedName: "aws.s3.S3BucketNotificationConfig")]
    public interface IS3BucketNotificationConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#bucket S3BucketNotification#bucket}.</summary>
        [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
        string Bucket
        {
            get;
        }

        /// <summary>lambda_function block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#lambda_function S3BucketNotification#lambda_function}
        /// </remarks>
        [JsiiProperty(name: "lambdaFunction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationLambdaFunction\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketNotificationLambdaFunction[]? LambdaFunction
        {
            get
            {
                return null;
            }
        }

        /// <summary>queue block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#queue S3BucketNotification#queue}
        /// </remarks>
        [JsiiProperty(name: "queue", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationQueue\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketNotificationQueue[]? Queue
        {
            get
            {
                return null;
            }
        }

        /// <summary>topic block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#topic S3BucketNotification#topic}
        /// </remarks>
        [JsiiProperty(name: "topic", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationTopic\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.S3.IS3BucketNotificationTopic[]? Topic
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Simple Storage Service.</summary>
        [JsiiTypeProxy(nativeType: typeof(IS3BucketNotificationConfig), fullyQualifiedName: "aws.s3.S3BucketNotificationConfig")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3BucketNotificationConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#bucket S3BucketNotification#bucket}.</summary>
            [JsiiProperty(name: "bucket", typeJson: "{\"primitive\":\"string\"}")]
            public string Bucket
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>lambda_function block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#lambda_function S3BucketNotification#lambda_function}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lambdaFunction", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationLambdaFunction\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.S3.IS3BucketNotificationLambdaFunction[]? LambdaFunction
            {
                get => GetInstanceProperty<aws.S3.IS3BucketNotificationLambdaFunction[]?>();
            }

            /// <summary>queue block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#queue S3BucketNotification#queue}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queue", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationQueue\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.S3.IS3BucketNotificationQueue[]? Queue
            {
                get => GetInstanceProperty<aws.S3.IS3BucketNotificationQueue[]?>();
            }

            /// <summary>topic block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3_bucket_notification#topic S3BucketNotification#topic}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "topic", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3BucketNotificationTopic\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.S3.IS3BucketNotificationTopic[]? Topic
            {
                get => GetInstanceProperty<aws.S3.IS3BucketNotificationTopic[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
