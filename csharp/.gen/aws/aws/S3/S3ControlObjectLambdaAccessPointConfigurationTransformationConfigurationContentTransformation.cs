using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation")]
    public class S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation : aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation
    {
        /// <summary>aws_lambda block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#aws_lambda S3ControlObjectLambdaAccessPoint#aws_lambda}
        /// </remarks>
        [JsiiProperty(name: "awsLambda", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda\"}", isOverride: true)]
        public aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformationAwsLambda AwsLambda
        {
            get;
            set;
        }
    }
}
