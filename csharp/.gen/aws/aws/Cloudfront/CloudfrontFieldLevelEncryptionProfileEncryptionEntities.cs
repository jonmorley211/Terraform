using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiByValue(fqn: "aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntities")]
    public class CloudfrontFieldLevelEncryptionProfileEncryptionEntities : aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntities
    {
        /// <summary>items block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#items CloudfrontFieldLevelEncryptionProfile#items}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItems[]? Items
        {
            get;
            set;
        }
    }
}
