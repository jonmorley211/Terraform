using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putContentTypeProfiles", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles\"}}]")]
        public virtual void PutContentTypeProfiles(aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles)}, new object[]{@value});
        }

        [JsiiProperty(name: "contentTypeProfiles", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesOutputReference ContentTypeProfiles
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "contentTypeProfilesInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles? ContentTypeProfilesInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardWhenContentTypeIsUnknownInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForwardWhenContentTypeIsUnknownInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "forwardWhenContentTypeIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForwardWhenContentTypeIsUnknown
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
