using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetItems")]
        public virtual void ResetItems()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "itemsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems[]? ItemsInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems[]?>();
        }

        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems\"},\"kind\":\"array\"}}")]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems[] Items
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles?>();
            set => SetInstanceProperty(value);
        }
    }
}
