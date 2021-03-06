using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiInterface(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionBucketDefinitions), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinitionBucketDefinitions")]
    public interface IMacie2ClassificationJobS3JobDefinitionBucketDefinitions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#account_id Macie2ClassificationJob#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        string AccountId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#buckets Macie2ClassificationJob#buckets}.</summary>
        [JsiiProperty(name: "buckets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Buckets
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2ClassificationJobS3JobDefinitionBucketDefinitions), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinitionBucketDefinitions")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#account_id Macie2ClassificationJob#account_id}.</summary>
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
            public string AccountId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#buckets Macie2ClassificationJob#buckets}.</summary>
            [JsiiProperty(name: "buckets", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Buckets
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
