using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems")]
    public interface ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems
    {
        /// <summary>field_patterns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#field_patterns CloudfrontFieldLevelEncryptionProfile#field_patterns}
        /// </remarks>
        [JsiiProperty(name: "fieldPatterns", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns\"}")]
        aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns FieldPatterns
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#provider_id CloudfrontFieldLevelEncryptionProfile#provider_id}.</summary>
        [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}")]
        string ProviderId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#public_key_id CloudfrontFieldLevelEncryptionProfile#public_key_id}.</summary>
        [JsiiProperty(name: "publicKeyId", typeJson: "{\"primitive\":\"string\"}")]
        string PublicKeyId
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>field_patterns block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#field_patterns CloudfrontFieldLevelEncryptionProfile#field_patterns}
            /// </remarks>
            [JsiiProperty(name: "fieldPatterns", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns\"}")]
            public aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns FieldPatterns
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#provider_id CloudfrontFieldLevelEncryptionProfile#provider_id}.</summary>
            [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}")]
            public string ProviderId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#public_key_id CloudfrontFieldLevelEncryptionProfile#public_key_id}.</summary>
            [JsiiProperty(name: "publicKeyId", typeJson: "{\"primitive\":\"string\"}")]
            public string PublicKeyId
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
