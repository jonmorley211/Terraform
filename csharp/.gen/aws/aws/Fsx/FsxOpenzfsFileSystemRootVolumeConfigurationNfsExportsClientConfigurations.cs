using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations")]
    public class FsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations : aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExportsClientConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#clients FsxOpenzfsFileSystem#clients}.</summary>
        [JsiiProperty(name: "clients", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Clients
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#options FsxOpenzfsFileSystem#options}.</summary>
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] Options
        {
            get;
            set;
        }
    }
}
