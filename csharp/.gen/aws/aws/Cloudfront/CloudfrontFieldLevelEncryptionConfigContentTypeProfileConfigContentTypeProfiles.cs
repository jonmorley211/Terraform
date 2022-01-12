using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles")]
    public class CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles : aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#items CloudfrontFieldLevelEncryptionConfig#items}
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfilesItems[] Items
        {
            get;
            set;
        }
    }
}
