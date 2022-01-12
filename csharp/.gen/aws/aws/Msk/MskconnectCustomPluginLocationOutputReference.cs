using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskconnectCustomPluginLocationOutputReference), fullyQualifiedName: "aws.msk.MskconnectCustomPluginLocationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MskconnectCustomPluginLocationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public MskconnectCustomPluginLocationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectCustomPluginLocationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskconnectCustomPluginLocationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putS3", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskconnectCustomPluginLocationS3\"}}]")]
        public virtual void PutS3(aws.Msk.IMskconnectCustomPluginLocationS3 @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskconnectCustomPluginLocationS3)}, new object[]{@value});
        }

        [JsiiProperty(name: "s3", typeJson: "{\"fqn\":\"aws.msk.MskconnectCustomPluginLocationS3OutputReference\"}")]
        public virtual aws.Msk.MskconnectCustomPluginLocationS3OutputReference S3
        {
            get => GetInstanceProperty<aws.Msk.MskconnectCustomPluginLocationS3OutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "s3Input", typeJson: "{\"fqn\":\"aws.msk.MskconnectCustomPluginLocationS3\"}", isOptional: true)]
        public virtual aws.Msk.IMskconnectCustomPluginLocationS3? S3Input
        {
            get => GetInstanceProperty<aws.Msk.IMskconnectCustomPluginLocationS3?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskconnectCustomPluginLocation\"}", isOptional: true)]
        public virtual aws.Msk.IMskconnectCustomPluginLocation? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskconnectCustomPluginLocation?>();
            set => SetInstanceProperty(value);
        }
    }
}
