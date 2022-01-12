using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig")]
    public class CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig : aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfig
    {
        /// <summary>content_type_profiles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#content_type_profiles CloudfrontFieldLevelEncryptionConfig#content_type_profiles}
        /// </remarks>
        [JsiiProperty(name: "contentTypeProfiles", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles\"}", isOverride: true)]
        public aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigContentTypeProfileConfigContentTypeProfiles ContentTypeProfiles
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#forward_when_content_type_is_unknown CloudfrontFieldLevelEncryptionConfig#forward_when_content_type_is_unknown}.</summary>
        [JsiiProperty(name: "forwardWhenContentTypeIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object ForwardWhenContentTypeIsUnknown
        {
            get;
            set;
        }
    }
}
