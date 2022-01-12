using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports), fullyQualifiedName: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports")]
    public interface IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports
    {
        /// <summary>client_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#client_configurations FsxOpenzfsFileSystem#client_configurations}
        /// </remarks>
        [JsiiProperty(name: "clientConfigurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations\"},\"kind\":\"array\"}}")]
        aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations[] ClientConfigurations
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports), fullyQualifiedName: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports")]
        internal sealed class _Proxy : DeputyBase, aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#client_configurations FsxOpenzfsFileSystem#client_configurations}
            /// </remarks>
            [JsiiProperty(name: "clientConfigurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations\"},\"kind\":\"array\"}}")]
            public aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations[] ClientConfigurations
            {
                get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations[]>()!;
            }
        }
    }
}
