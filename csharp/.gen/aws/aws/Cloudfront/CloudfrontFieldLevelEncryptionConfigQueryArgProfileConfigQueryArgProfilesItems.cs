using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems")]
    public class CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems : aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfilesItems
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#profile_id CloudfrontFieldLevelEncryptionConfig#profile_id}.</summary>
        [JsiiProperty(name: "profileId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ProfileId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#query_arg CloudfrontFieldLevelEncryptionConfig#query_arg}.</summary>
        [JsiiProperty(name: "queryArg", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string QueryArg
        {
            get;
            set;
        }
    }
}
