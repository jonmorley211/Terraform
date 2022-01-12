using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiInterface(nativeType: typeof(IFsxOpenzfsVolumeNfsExports), fullyQualifiedName: "aws.fsx.FsxOpenzfsVolumeNfsExports")]
    public interface IFsxOpenzfsVolumeNfsExports
    {
        /// <summary>client_configurations block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume#client_configurations FsxOpenzfsVolume#client_configurations}
        /// </remarks>
        [JsiiProperty(name: "clientConfigurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeNfsExportsClientConfigurations\"},\"kind\":\"array\"}}")]
        aws.Fsx.IFsxOpenzfsVolumeNfsExportsClientConfigurations[] ClientConfigurations
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOpenzfsVolumeNfsExports), fullyQualifiedName: "aws.fsx.FsxOpenzfsVolumeNfsExports")]
        internal sealed class _Proxy : DeputyBase, aws.Fsx.IFsxOpenzfsVolumeNfsExports
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>client_configurations block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_openzfs_volume#client_configurations FsxOpenzfsVolume#client_configurations}
            /// </remarks>
            [JsiiProperty(name: "clientConfigurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeNfsExportsClientConfigurations\"},\"kind\":\"array\"}}")]
            public aws.Fsx.IFsxOpenzfsVolumeNfsExportsClientConfigurations[] ClientConfigurations
            {
                get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsVolumeNfsExportsClientConfigurations[]>()!;
            }
        }
    }
}
