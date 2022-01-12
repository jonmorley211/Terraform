using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiByValue(fqn: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfiguration")]
    public class FsxOpenzfsFileSystemRootVolumeConfiguration : aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#copy_tags_to_snapshots FsxOpenzfsFileSystem#copy_tags_to_snapshots}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyTagsToSnapshots", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? CopyTagsToSnapshots
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#data_compression_type FsxOpenzfsFileSystem#data_compression_type}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataCompressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DataCompressionType
        {
            get;
            set;
        }

        /// <summary>nfs_exports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#nfs_exports FsxOpenzfsFileSystem#nfs_exports}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nfsExports", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports\"}", isOptional: true, isOverride: true)]
        public aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports? NfsExports
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#read_only FsxOpenzfsFileSystem#read_only}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? ReadOnly
        {
            get;
            set;
        }

        /// <summary>user_and_group_quotas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#user_and_group_quotas FsxOpenzfsFileSystem#user_and_group_quotas}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userAndGroupQuotas", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas[]? UserAndGroupQuotas
        {
            get;
            set;
        }
    }
}
