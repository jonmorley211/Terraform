using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsOutputReference), fullyQualifiedName: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientConfigurationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations[]? ClientConfigurationsInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations[]?>();
        }

        [JsiiProperty(name: "clientConfigurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations\"},\"kind\":\"array\"}}")]
        public virtual aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations[] ClientConfigurations
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports? InternalValue
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports?>();
            set => SetInstanceProperty(value);
        }
    }
}
