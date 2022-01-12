using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecs
{
    [JsiiClass(nativeType: typeof(aws.Ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationOutputReference), fullyQualifiedName: "aws.ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAuthorizationConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig\"}}]")]
        public virtual void PutAuthorizationConfig(aws.Ecs.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Ecs.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig)}, new object[]{@value});
        }

        [JsiiProperty(name: "authorizationConfig", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfigOutputReference\"}")]
        public virtual aws.Ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfigOutputReference AuthorizationConfig
        {
            get => GetInstanceProperty<aws.Ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "authorizationConfigInput", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig? AuthorizationConfigInput
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfigurationAuthorizationConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileSystemIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileSystemIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rootDirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RootDirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "fileSystemId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileSystemId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rootDirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RootDirectory
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecs.EcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration\"}", isOptional: true)]
        public virtual aws.Ecs.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Ecs.IEcsTaskDefinitionVolumeFsxWindowsFileServerVolumeConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
