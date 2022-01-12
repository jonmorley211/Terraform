using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskconnectCustomPluginLocationS3OutputReference), fullyQualifiedName: "aws.msk.MskconnectCustomPluginLocationS3OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MskconnectCustomPluginLocationS3OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public MskconnectCustomPluginLocationS3OutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectCustomPluginLocationS3OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectCustomPluginLocationS3OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetObjectVersion")]
        public virtual void ResetObjectVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "bucketArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BucketArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "objectVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ObjectVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "bucketArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BucketArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "objectVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ObjectVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskconnectCustomPluginLocationS3\"}", isOptional: true)]
        public virtual aws.Msk.IMskconnectCustomPluginLocationS3? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskconnectCustomPluginLocationS3?>();
            set => SetInstanceProperty(value);
        }
    }
}
