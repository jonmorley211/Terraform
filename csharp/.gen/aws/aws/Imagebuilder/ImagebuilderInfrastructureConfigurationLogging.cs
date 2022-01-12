using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.imagebuilder.ImagebuilderInfrastructureConfigurationLogging")]
    public class ImagebuilderInfrastructureConfigurationLogging : aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLogging
    {
        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_infrastructure_configuration#s3_logs ImagebuilderInfrastructureConfiguration#s3_logs}
        /// </remarks>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderInfrastructureConfigurationLoggingS3Logs\"}", isOverride: true)]
        public aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLoggingS3Logs S3Logs
        {
            get;
            set;
        }
    }
}
