using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Quicksight
{
    [JsiiClass(nativeType: typeof(aws.Quicksight.QuicksightDataSourceParametersS3OutputReference), fullyQualifiedName: "aws.quicksight.QuicksightDataSourceParametersS3OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class QuicksightDataSourceParametersS3OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public QuicksightDataSourceParametersS3OutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceParametersS3OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected QuicksightDataSourceParametersS3OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putManifestFileLocation", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3ManifestFileLocation\"}}]")]
        public virtual void PutManifestFileLocation(aws.Quicksight.IQuicksightDataSourceParametersS3ManifestFileLocation @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Quicksight.IQuicksightDataSourceParametersS3ManifestFileLocation)}, new object[]{@value});
        }

        [JsiiProperty(name: "manifestFileLocation", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3ManifestFileLocationOutputReference\"}")]
        public virtual aws.Quicksight.QuicksightDataSourceParametersS3ManifestFileLocationOutputReference ManifestFileLocation
        {
            get => GetInstanceProperty<aws.Quicksight.QuicksightDataSourceParametersS3ManifestFileLocationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "manifestFileLocationInput", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3ManifestFileLocation\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersS3ManifestFileLocation? ManifestFileLocationInput
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersS3ManifestFileLocation?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.quicksight.QuicksightDataSourceParametersS3\"}", isOptional: true)]
        public virtual aws.Quicksight.IQuicksightDataSourceParametersS3? InternalValue
        {
            get => GetInstanceProperty<aws.Quicksight.IQuicksightDataSourceParametersS3?>();
            set => SetInstanceProperty(value);
        }
    }
}
