using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiByValue(fqn: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludes")]
    public class Macie2ClassificationJobS3JobDefinitionScopingExcludes : aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludes
    {
        /// <summary>and block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#and Macie2ClassificationJob#and}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "and", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAnd\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd[]? And
        {
            get;
            set;
        }
    }
}
