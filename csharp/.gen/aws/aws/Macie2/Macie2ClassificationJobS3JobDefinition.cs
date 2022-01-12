using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiByValue(fqn: "aws.macie2.Macie2ClassificationJobS3JobDefinition")]
    public class Macie2ClassificationJobS3JobDefinition : aws.Macie2.IMacie2ClassificationJobS3JobDefinition
    {
        /// <summary>bucket_definitions block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#bucket_definitions Macie2ClassificationJob#bucket_definitions}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "bucketDefinitions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionBucketDefinitions\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionBucketDefinitions[]? BucketDefinitions
        {
            get;
            set;
        }

        /// <summary>scoping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#scoping Macie2ClassificationJob#scoping}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scoping", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScoping\"}", isOptional: true, isOverride: true)]
        public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping? Scoping
        {
            get;
            set;
        }
    }
}
