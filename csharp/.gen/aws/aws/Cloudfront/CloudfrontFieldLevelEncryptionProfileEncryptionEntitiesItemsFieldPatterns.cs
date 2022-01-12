using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns")]
    public class CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns : aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#items CloudfrontFieldLevelEncryptionProfile#items}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Items
        {
            get;
            set;
        }
    }
}
