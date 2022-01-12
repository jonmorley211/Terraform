using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Imagebuilder
{
    [JsiiClass(nativeType: typeof(aws.Imagebuilder.ImagebuilderInfrastructureConfigurationLoggingOutputReference), fullyQualifiedName: "aws.imagebuilder.ImagebuilderInfrastructureConfigurationLoggingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ImagebuilderInfrastructureConfigurationLoggingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ImagebuilderInfrastructureConfigurationLoggingOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderInfrastructureConfigurationLoggingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ImagebuilderInfrastructureConfigurationLoggingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3Logs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.imagebuilder.ImagebuilderInfrastructureConfigurationLoggingS3Logs\"}}]")]
        public virtual void PutS3Logs(aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLoggingS3Logs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLoggingS3Logs)}, new object[]{@value});
        }

        [JsiiProperty(name: "s3Logs", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderInfrastructureConfigurationLoggingS3LogsOutputReference\"}")]
        public virtual aws.Imagebuilder.ImagebuilderInfrastructureConfigurationLoggingS3LogsOutputReference S3Logs
        {
            get => GetInstanceProperty<aws.Imagebuilder.ImagebuilderInfrastructureConfigurationLoggingS3LogsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3LogsInput", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderInfrastructureConfigurationLoggingS3Logs\"}", isOptional: true)]
        public virtual aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLoggingS3Logs? S3LogsInput
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLoggingS3Logs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.imagebuilder.ImagebuilderInfrastructureConfigurationLogging\"}", isOptional: true)]
        public virtual aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLogging? InternalValue
        {
            get => GetInstanceProperty<aws.Imagebuilder.IImagebuilderInfrastructureConfigurationLogging?>();
            set => SetInstanceProperty(value);
        }
    }
}
