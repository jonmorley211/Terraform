using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.macie2.Macie2FindingsFilterFindingCriteriaCriterion")]
    public class Macie2FindingsFilterFindingCriteriaCriterion : aws.Macie2.IMacie2FindingsFilterFindingCriteriaCriterion
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#field Macie2FindingsFilter#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Field
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#eq Macie2FindingsFilter#eq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Eq
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#eq_exact_match Macie2FindingsFilter#eq_exact_match}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "eqExactMatch", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? EqExactMatch
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#gt Macie2FindingsFilter#gt}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gt", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Gt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#gte Macie2FindingsFilter#gte}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "gte", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Gte
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#lt Macie2FindingsFilter#lt}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lt", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Lt
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#lte Macie2FindingsFilter#lte}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lte", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Lte
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#neq Macie2FindingsFilter#neq}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "neq", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? Neq
        {
            get;
            set;
        }
    }
}
