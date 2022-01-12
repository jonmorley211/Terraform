using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation")]
    public interface IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation
    {
        /// <summary>aws_lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#aws_lambda S3ControlObjectLambdaAccessPoint#aws_lambda}
        /// </remarks>
        [JsiiProperty(name: "awsLambda", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda\"}")]
        aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda AwsLambda
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>aws_lambda block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#aws_lambda S3ControlObjectLambdaAccessPoint#aws_lambda}
            /// </remarks>
            [JsiiProperty(name: "awsLambda", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda\"}")]
            public aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda AwsLambda
            {
                get => GetInstanceProperty<aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda>()!;
            }
        }
    }
}
