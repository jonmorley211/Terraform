using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3ControlObjectLambdaAccessPointConfiguration), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfiguration")]
    public interface IS3ControlObjectLambdaAccessPointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#supporting_access_point S3ControlObjectLambdaAccessPoint#supporting_access_point}.</summary>
        [JsiiProperty(name: "supportingAccessPoint", typeJson: "{\"primitive\":\"string\"}")]
        string SupportingAccessPoint
        {
            get;
        }

        /// <summary>transformation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#transformation_configuration S3ControlObjectLambdaAccessPoint#transformation_configuration}
        /// </remarks>
        [JsiiProperty(name: "transformationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration\"},\"kind\":\"array\"}}")]
        aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration[] TransformationConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#allowed_features S3ControlObjectLambdaAccessPoint#allowed_features}.</summary>
        [JsiiProperty(name: "allowedFeatures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AllowedFeatures
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#cloud_watch_metrics_enabled S3ControlObjectLambdaAccessPoint#cloud_watch_metrics_enabled}.</summary>
        [JsiiProperty(name: "cloudWatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CloudWatchMetricsEnabled
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlObjectLambdaAccessPointConfiguration), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3ControlObjectLambdaAccessPointConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#supporting_access_point S3ControlObjectLambdaAccessPoint#supporting_access_point}.</summary>
            [JsiiProperty(name: "supportingAccessPoint", typeJson: "{\"primitive\":\"string\"}")]
            public string SupportingAccessPoint
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>transformation_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#transformation_configuration S3ControlObjectLambdaAccessPoint#transformation_configuration}
            /// </remarks>
            [JsiiProperty(name: "transformationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration\"},\"kind\":\"array\"}}")]
            public aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration[] TransformationConfiguration
            {
                get => GetInstanceProperty<aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#allowed_features S3ControlObjectLambdaAccessPoint#allowed_features}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "allowedFeatures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AllowedFeatures
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#cloud_watch_metrics_enabled S3ControlObjectLambdaAccessPoint#cloud_watch_metrics_enabled}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cloudWatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CloudWatchMetricsEnabled
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
