using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig")]
    public class CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig : aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#forward_when_query_arg_profile_is_unknown CloudfrontFieldLevelEncryptionConfig#forward_when_query_arg_profile_is_unknown}.</summary>
        [JsiiProperty(name: "forwardWhenQueryArgProfileIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object ForwardWhenQueryArgProfileIsUnknown
        {
            get;
            set;
        }

        /// <summary>query_arg_profiles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#query_arg_profiles CloudfrontFieldLevelEncryptionConfig#query_arg_profiles}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "queryArgProfiles", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles\"}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles? QueryArgProfiles
        {
            get;
            set;
        }
    }
}
