using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiInterface(nativeType: typeof(IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda")]
    public interface IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#function_arn S3ControlObjectLambdaAccessPoint#function_arn}.</summary>
        [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
        string FunctionArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#function_payload S3ControlObjectLambdaAccessPoint#function_payload}.</summary>
        [JsiiProperty(name: "functionPayload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FunctionPayload
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda")]
        internal sealed class _Proxy : DeputyBase, aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#function_arn S3ControlObjectLambdaAccessPoint#function_arn}.</summary>
            [JsiiProperty(name: "functionArn", typeJson: "{\"primitive\":\"string\"}")]
            public string FunctionArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#function_payload S3ControlObjectLambdaAccessPoint#function_payload}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "functionPayload", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FunctionPayload
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
