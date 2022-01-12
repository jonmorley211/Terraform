using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns")]
    public interface ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#items CloudfrontFieldLevelEncryptionProfile#items}.</summary>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Items
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontFieldLevelEncryptionProfileEncryptionEntitiesItemsFieldPatterns
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_profile#items CloudfrontFieldLevelEncryptionProfile#items}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Items
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
