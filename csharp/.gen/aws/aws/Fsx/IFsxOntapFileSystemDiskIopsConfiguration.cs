using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiInterface(nativeType: typeof(IFsxOntapFileSystemDiskIopsConfiguration), fullyQualifiedName: "aws.fsx.FsxOntapFileSystemDiskIopsConfiguration")]
    public interface IFsxOntapFileSystemDiskIopsConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_file_system#iops FsxOntapFileSystem#iops}.</summary>
        [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Iops
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_file_system#mode FsxOntapFileSystem#mode}.</summary>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Mode
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOntapFileSystemDiskIopsConfiguration), fullyQualifiedName: "aws.fsx.FsxOntapFileSystemDiskIopsConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Fsx.IFsxOntapFileSystemDiskIopsConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_file_system#iops FsxOntapFileSystem#iops}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iops", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Iops
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_file_system#mode FsxOntapFileSystem#mode}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Mode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
