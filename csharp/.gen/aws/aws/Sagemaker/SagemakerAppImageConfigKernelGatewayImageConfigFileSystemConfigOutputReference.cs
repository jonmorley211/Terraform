using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDefaultGid")]
        public virtual void ResetDefaultGid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultUid")]
        public virtual void ResetDefaultUid()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMountPath")]
        public virtual void ResetMountPath()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultGidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultGidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultUidInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? DefaultUidInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "mountPathInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MountPathInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "defaultGid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultGid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "defaultUid", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double DefaultUid
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MountPath
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerAppImageConfigKernelGatewayImageConfigFileSystemConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
