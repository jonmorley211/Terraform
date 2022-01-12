using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3ControlMultiRegionAccessPointDetailsOutputReference), fullyQualifiedName: "aws.s3.S3ControlMultiRegionAccessPointDetailsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3ControlMultiRegionAccessPointDetailsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3ControlMultiRegionAccessPointDetailsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlMultiRegionAccessPointDetailsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlMultiRegionAccessPointDetailsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putPublicAccessBlock", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsPublicAccessBlock\"}}]")]
        public virtual void PutPublicAccessBlock(aws.S3.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.S3.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetPublicAccessBlock")]
        public virtual void ResetPublicAccessBlock()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "publicAccessBlock", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsPublicAccessBlockOutputReference\"}")]
        public virtual aws.S3.S3ControlMultiRegionAccessPointDetailsPublicAccessBlockOutputReference PublicAccessBlock
        {
            get => GetInstanceProperty<aws.S3.S3ControlMultiRegionAccessPointDetailsPublicAccessBlockOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "publicAccessBlockInput", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsPublicAccessBlock\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock? PublicAccessBlockInput
        {
            get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointDetailsPublicAccessBlock?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsRegion\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.S3.IS3ControlMultiRegionAccessPointDetailsRegion[]? RegionInput
        {
            get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointDetailsRegion[]?>();
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "region", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetailsRegion\"},\"kind\":\"array\"}}")]
        public virtual aws.S3.IS3ControlMultiRegionAccessPointDetailsRegion[] Region
        {
            get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointDetailsRegion[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3ControlMultiRegionAccessPointDetails\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlMultiRegionAccessPointDetails? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3ControlMultiRegionAccessPointDetails?>();
            set => SetInstanceProperty(value);
        }
    }
}
