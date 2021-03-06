using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems")]
    public class CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems : aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems
    {
        /// <summary>field_patterns block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#field_patterns CloudfrontFieldLevelEncryptionProfile#field_patterns}
        /// </remarks>
        [JsiiProperty(name: "fieldPatterns", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns FieldPatterns
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#provider_id CloudfrontFieldLevelEncryptionProfile#provider_id}.</summary>
        [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ProviderId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#public_key_id CloudfrontFieldLevelEncryptionProfile#public_key_id}.</summary>
        [JsiiProperty(name: "publicKeyId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PublicKeyId
        {
            get;
            set;
        }
    }
}
