using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig")]
    public interface ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig
    {
        /// <summary>content_type_profiles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#content_type_profiles CloudfrontFieldLevelEncryptionConfig#content_type_profiles}
        /// </remarks>
        [JsiiProperty(name: "contentTypeProfiles", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles\"}")]
        aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles ContentTypeProfiles
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#forward_when_content_type_is_unknown CloudfrontFieldLevelEncryptionConfig#forward_when_content_type_is_unknown}.</summary>
        [JsiiProperty(name: "forwardWhenContentTypeIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ForwardWhenContentTypeIsUnknown
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>content_type_profiles block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#content_type_profiles CloudfrontFieldLevelEncryptionConfig#content_type_profiles}
            /// </remarks>
            [JsiiProperty(name: "contentTypeProfiles", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles\"}")]
            public aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles ContentTypeProfiles
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#forward_when_content_type_is_unknown CloudfrontFieldLevelEncryptionConfig#forward_when_content_type_is_unknown}.</summary>
            [JsiiProperty(name: "forwardWhenContentTypeIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ForwardWhenContentTypeIsUnknown
            {
                get => GetInstanceProperty<object>()!;
            }
        }
    }
}
