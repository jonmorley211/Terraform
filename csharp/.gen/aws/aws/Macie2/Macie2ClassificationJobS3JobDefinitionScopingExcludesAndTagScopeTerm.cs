using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiByValue(fqn: "aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm")]
    public class Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm : aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTerm
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#comparator Macie2ClassificationJob#comparator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "comparator", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Comparator
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#key Macie2ClassificationJob#key}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>tag_values block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#tag_values Macie2ClassificationJob#tag_values}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tagValues", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTermTagValues\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Macie2.IMacie2ClassificationJobS3JobDefinitionScopingExcludesAndTagScopeTermTagValues[]? TagValues
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_classification_job#target Macie2ClassificationJob#target}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Target
        {
            get;
            set;
        }
    }
}
