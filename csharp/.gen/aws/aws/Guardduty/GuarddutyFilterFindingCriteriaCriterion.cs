using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.guardduty.GuarddutyFilterFindingCriteriaCriterion")]
    public class GuarddutyFilterFindingCriteriaCriterion : aws.Guardduty.IGuarddutyFilterFindingCriteriaCriterion
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#field GuarddutyFilter#field}.</summary>
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Field
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#equals GuarddutyFilter#equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "equalTo", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? EqualTo
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#greater_than GuarddutyFilter#greater_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "greaterThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GreaterThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#greater_than_or_equal GuarddutyFilter#greater_than_or_equal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "greaterThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? GreaterThanOrEqual
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#less_than GuarddutyFilter#less_than}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lessThan", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LessThan
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#less_than_or_equal GuarddutyFilter#less_than_or_equal}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "lessThanOrEqual", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LessThanOrEqual
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#not_equals GuarddutyFilter#not_equals}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "notEquals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? NotEquals
        {
            get;
            set;
        }
    }
}
