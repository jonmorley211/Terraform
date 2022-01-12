using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiByValue(fqn: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAnd")]
    public class Macie2ClassificationJobS3JobDefinitionScopingExcludesAnd : aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAnd
    {
        /// <summary>simple_scope_term block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#simple_scope_term Macie2ClassificationJob#simple_scope_term}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "simpleScopeTerm", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndSimpleScopeTerm\"}", isOptional: true, isOverride: true)]
        public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndSimpleScopeTerm? SimpleScopeTerm
        {
            get;
            set;
        }

        /// <summary>tag_scope_term block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#tag_scope_term Macie2ClassificationJob#tag_scope_term}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagScopeTerm", typeJson: "{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm\"}", isOptional: true, isOverride: true)]
        public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm? TagScopeTerm
        {
            get;
            set;
        }
    }
}
