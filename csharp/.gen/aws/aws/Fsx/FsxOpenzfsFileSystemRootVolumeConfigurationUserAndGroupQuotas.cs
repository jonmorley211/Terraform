using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas")]
    public class FsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas : aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#id FsxOpenzfsFileSystem#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double Id
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#storage_capacity_quota_gib FsxOpenzfsFileSystem#storage_capacity_quota_gib}.</summary>
        [JsiiProperty(name: "storageCapacityQuotaGib", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double StorageCapacityQuotaGib
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#type FsxOpenzfsFileSystem#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Type
        {
            get;
            set;
        }
    }
}
