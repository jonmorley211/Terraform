using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration")]
    public class S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration : aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#actions S3ControlObjectLambdaAccessPoint#actions}.</summary>
        [JsiiProperty(name: "actions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Actions
        {
            get;
            set;
        }

        /// <summary>content_transformation block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#content_transformation S3ControlObjectLambdaAccessPoint#content_transformation}
        /// </remarks>
        [JsiiProperty(name: "contentTransformation", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation\"}", isOverride: true)]
        public aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfigurationContentTransformation ContentTransformation
        {
            get;
            set;
        }
    }
}
