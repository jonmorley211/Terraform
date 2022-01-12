using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.s3.S3ControlObjectLambdaAccessPointConfiguration")]
    public class S3ControlObjectLambdaAccessPointConfiguration : aws.S3.IS3ControlObjectLambdaAccessPointConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#supporting_access_point S3ControlObjectLambdaAccessPoint#supporting_access_point}.</summary>
        [JsiiProperty(name: "supportingAccessPoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SupportingAccessPoint
        {
            get;
            set;
        }

        /// <summary>transformation_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#transformation_configuration S3ControlObjectLambdaAccessPoint#transformation_configuration}
        /// </remarks>
        [JsiiProperty(name: "transformationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration[] TransformationConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#allowed_features S3ControlObjectLambdaAccessPoint#allowed_features}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "allowedFeatures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? AllowedFeatures
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/s3control_object_lambda_access_point#cloud_watch_metrics_enabled S3ControlObjectLambdaAccessPoint#cloud_watch_metrics_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? CloudWatchMetricsEnabled
        {
            get;
            set;
        }
    }
}
