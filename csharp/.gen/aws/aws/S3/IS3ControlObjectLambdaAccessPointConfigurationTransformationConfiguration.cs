using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration")]
    public interface IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#actions S3ControlObjectLambdaAccessPoint#actions}.</summary>
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Actions
        {
            get;
        }

        /// <summary>content_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#content_transformation S3ControlObjectLambdaAccessPoint#content_transformation}
        /// </remarks>
        [JsiiProperty(name: "contentTransformation", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation\"}")]
        aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation ContentTransformation
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#actions S3ControlObjectLambdaAccessPoint#actions}.</summary>
            [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Actions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>content_transformation block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#content_transformation S3ControlObjectLambdaAccessPoint#content_transformation}
            /// </remarks>
            [JsiiProperty(name: "contentTransformation", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation\"}")]
            public aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation ContentTransformation
            {
                get => GetInstanceProperty<aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation>()!;
            }
        }
    }
}
