using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiInterface(nativeType: typeof(IMacie2ClassificationJobS3JobDefinition), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinition")]
    public interface IMacie2ClassificationJobS3JobDefinition
    {
        /// <summary>bucket_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#bucket_definitions Macie2ClassificationJob#bucket_definitions}
        /// </remarks>
        [JsiiProperty(name: "bucketDefinitions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[]? BucketDefinitions
        {
            get
            {
                return null;
            }
        }

        /// <summary>scoping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#scoping Macie2ClassificationJob#scoping}
        /// </remarks>
        [JsiiProperty(name: "scoping", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScoping\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping? Scoping
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2ClassificationJobS3JobDefinition), fullyQualifiedName: "aws.macie2.Macie2ClassificationJobS3JobDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2.IMacie2ClassificationJobS3JobDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>bucket_definitions block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#bucket_definitions Macie2ClassificationJob#bucket_definitions}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "bucketDefinitions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[]? BucketDefinitions
            {
                get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[]?>();
            }

            /// <summary>scoping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#scoping Macie2ClassificationJob#scoping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scoping", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScoping\"}", isOptional: true)]
            public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping? Scoping
            {
                get => GetInstanceProperty<aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping?>();
            }
        }
    }
}
