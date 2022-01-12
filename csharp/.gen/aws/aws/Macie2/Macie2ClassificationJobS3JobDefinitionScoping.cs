using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiByValue(fqn: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScoping")]
    public class Macie2ClassificationJobS3JobDefinitionScoping : aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScoping
    {
        /// <summary>excludes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#excludes Macie2ClassificationJob#excludes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "excludes", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludes\"}", isOptional: true, isOverride: true)]
        public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludes? Excludes
        {
            get;
            set;
        }

        /// <summary>includes block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#includes Macie2ClassificationJob#includes}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "includes", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingIncludes\"}", isOptional: true, isOverride: true)]
        public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingIncludes? Includes
        {
            get;
            set;
        }
    }
}
