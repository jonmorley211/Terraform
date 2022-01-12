using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiClass(nativeType: typeof(aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putQueryArgProfiles", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles\"}}]")]
        public virtual void PutQueryArgProfiles(aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetQueryArgProfiles")]
        public virtual void ResetQueryArgProfiles()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "queryArgProfiles", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference\"}")]
        public virtual aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference QueryArgProfiles
        {
            get => GetInstanceProperty<aws.Cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "forwardWhenQueryArgProfileIsUnknownInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? ForwardWhenQueryArgProfileIsUnknownInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "queryArgProfilesInput", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles? QueryArgProfilesInput
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles?>();
        }

        [JsiiProperty(name: "forwardWhenQueryArgProfileIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object ForwardWhenQueryArgProfileIsUnknown
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig\"}", isOptional: true)]
        public virtual aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
