using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas), fullyQualifiedName: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas")]
    public interface IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#id FsxOpenzfsFileSystem#id}.</summary>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        double Id
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#storage_capacity_quota_gib FsxOpenzfsFileSystem#storage_capacity_quota_gib}.</summary>
        [JsiiProperty(name: "storageCapacityQuotaGib", typeJson: "{\"primitive\":\"number\"}")]
        double StorageCapacityQuotaGib
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#type FsxOpenzfsFileSystem#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas), fullyQualifiedName: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas")]
        internal sealed class _Proxy : DeputyBase, aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#id FsxOpenzfsFileSystem#id}.</summary>
            [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
            public double Id
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#storage_capacity_quota_gib FsxOpenzfsFileSystem#storage_capacity_quota_gib}.</summary>
            [JsiiProperty(name: "storageCapacityQuotaGib", typeJson: "{\"primitive\":\"number\"}")]
            public double StorageCapacityQuotaGib
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#type FsxOpenzfsFileSystem#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
