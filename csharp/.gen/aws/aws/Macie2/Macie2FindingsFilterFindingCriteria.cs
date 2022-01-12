using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiByValue(fqn: "aws.macie2.Macie2FindingsFilterFindingCriteria")]
    public class Macie2FindingsFilterFindingCriteria : aws.Macie2.IMacie2FindingsFilterFindingCriteria
    {
        /// <summary>criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#criterion Macie2FindingsFilter#criterion}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "criterion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Macie2.IMacie2FindingsFilterFindingCriteriaCriterion[]? Criterion
        {
            get;
            set;
        }
    }
}
