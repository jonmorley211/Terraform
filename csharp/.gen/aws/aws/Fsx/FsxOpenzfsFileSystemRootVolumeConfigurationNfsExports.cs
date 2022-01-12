using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports")]
    public class FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports : aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports
    {
        /// <summary>client_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#client_configurations FsxOpenzfsFileSystem#client_configurations}
        /// </remarks>
        [JsiiProperty(name: "clientConfigurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations[] ClientConfigurations
        {
            get;
            set;
        }
    }
}
