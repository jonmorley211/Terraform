using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsVolumeNfsExportsClientConfigurations), fullyQualifiedName: "aws.fsx.FsxOpenzfsVolumeNfsExportsClientConfigurations")]
    public interface IFsxOpenzfsVolumeNfsExportsClientConfigurations
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume#clients FsxOpenzfsVolume#clients}.</summary>
        [JsiiProperty(name: "clients", typeJson: "{\"primitive\":\"string\"}")]
        string Clients
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume#options FsxOpenzfsVolume#options}.</summary>
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Options
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsVolumeNfsExportsClientConfigurations), fullyQualifiedName: "aws.fsx.FsxOpenzfsVolumeNfsExportsClientConfigurations")]
        internal sealed class _Proxy : DeputyBase, aws.Fsx.IFsxOpenzfsVolumeNfsExportsClientConfigurations
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume#clients FsxOpenzfsVolume#clients}.</summary>
            [JsiiProperty(name: "clients", typeJson: "{\"primitive\":\"string\"}")]
            public string Clients
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume#options FsxOpenzfsVolume#options}.</summary>
            [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Options
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
