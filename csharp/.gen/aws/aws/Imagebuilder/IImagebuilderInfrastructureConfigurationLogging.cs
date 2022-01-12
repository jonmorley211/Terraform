using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    [JsiiInterface(nativeType: typeof(IImagebuilderInfrastructureConfigurationLogging), fullyQualifiedName: "aws.imagebuilder.ImagebuilderInfrastructureConfigurationLogging")]
    public interface IImagebuilderInfrastructureConfigurationLogging
    {
        /// <summary>s3_logs block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_infrastructure_configuration#s3_logs ImagebuilderInfrastructureConfiguration#s3_logs}
        /// </remarks>
        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderInfrastructureConfigurationLoggingS3Logs\"}")]
        aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLoggingS3Logs S3Logs
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IImagebuilderInfrastructureConfigurationLogging), fullyQualifiedName: "aws.imagebuilder.ImagebuilderInfrastructureConfigurationLogging")]
        internal sealed class _Proxy : DeputyBase, aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLogging
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>s3_logs block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/imagebuilder_infrastructure_configuration#s3_logs ImagebuilderInfrastructureConfiguration#s3_logs}
            /// </remarks>
            [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderInfrastructureConfigurationLoggingS3Logs\"}")]
            public aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLoggingS3Logs S3Logs
            {
                get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLoggingS3Logs>()!;
            }
        }
    }
}
