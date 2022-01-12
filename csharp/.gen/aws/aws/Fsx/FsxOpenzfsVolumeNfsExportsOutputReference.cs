using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxOpenzfsVolumeNfsExportsOutputReference), fullyQualifiedName: "aws.fsx.FsxOpenzfsVolumeNfsExportsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FsxOpenzfsVolumeNfsExportsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public FsxOpenzfsVolumeNfsExportsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsVolumeNfsExportsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOpenzfsVolumeNfsExportsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientConfigurationsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeNfsExportsClientConfigurations\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsVolumeNfsExportsClientConfigurations[]? ClientConfigurationsInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsVolumeNfsExportsClientConfigurations[]?>();
        }

        [JsiiProperty(name: "clientConfigurations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeNfsExportsClientConfigurations\"},\"kind\":\"array\"}}")]
        public virtual aws.Fsx.IFsxOpenzfsVolumeNfsExportsClientConfigurations[] ClientConfigurations
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsVolumeNfsExportsClientConfigurations[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsx.FsxOpenzfsVolumeNfsExports\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOpenzfsVolumeNfsExports? InternalValue
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOpenzfsVolumeNfsExports?>();
            set => SetInstanceProperty(value);
        }
    }
}
