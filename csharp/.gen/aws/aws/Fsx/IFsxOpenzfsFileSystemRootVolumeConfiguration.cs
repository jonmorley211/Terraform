using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfiguration), fullyQualifiedName: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfiguration")]
    public interface IFsxOpenzfsFileSystemRootVolumeConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#copy_tags_to_snapshots FsxOpenzfsFileSystem#copy_tags_to_snapshots}.</summary>
        [JsiiProperty(name: "copyTagsToSnapshots", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? CopyTagsToSnapshots
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#data_compression_type FsxOpenzfsFileSystem#data_compression_type}.</summary>
        [JsiiProperty(name: "dataCompressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DataCompressionType
        {
            get
            {
                return null;
            }
        }

        /// <summary>nfs_exports block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#nfs_exports FsxOpenzfsFileSystem#nfs_exports}
        /// </remarks>
        [JsiiProperty(name: "nfsExports", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports? NfsExports
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#read_only FsxOpenzfsFileSystem#read_only}.</summary>
        [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? ReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>user_and_group_quotas block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#user_and_group_quotas FsxOpenzfsFileSystem#user_and_group_quotas}
        /// </remarks>
        [JsiiProperty(name: "userAndGroupQuotas", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas[]? UserAndGroupQuotas
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsFileSystemRootVolumeConfiguration), fullyQualifiedName: "aws.fsx.FsxOpenzfsFileSystemRootVolumeConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#copy_tags_to_snapshots FsxOpenzfsFileSystem#copy_tags_to_snapshots}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "copyTagsToSnapshots", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? CopyTagsToSnapshots
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#data_compression_type FsxOpenzfsFileSystem#data_compression_type}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "dataCompressionType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DataCompressionType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>nfs_exports block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#nfs_exports FsxOpenzfsFileSystem#nfs_exports}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nfsExports", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationNfsExports\"}", isOptional: true)]
            public aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports? NfsExports
            {
                get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationNfsExports?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#read_only FsxOpenzfsFileSystem#read_only}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? ReadOnly
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>user_and_group_quotas block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_file_system#user_and_group_quotas FsxOpenzfsFileSystem#user_and_group_quotas}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "userAndGroupQuotas", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas[]? UserAndGroupQuotas
            {
                get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsFileSystemRootVolumeConfigurationUserAndGroupQuotas[]?>();
            }
        }
    }
}
