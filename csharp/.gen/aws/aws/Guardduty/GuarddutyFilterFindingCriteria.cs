using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.guardduty.GuarddutyFilterFindingCriteria")]
    public class GuarddutyFilterFindingCriteria : aws.Guardduty.IGuarddutyFilterFindingCriteria
    {
        /// <summary>criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#criterion GuarddutyFilter#criterion}
        /// </remarks>
        [JsiiProperty(name: "criterion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.guardduty.GuarddutyFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Guardduty.IGuarddutyFilterFindingCriteriaCriterion[] Criterion
        {
            get;
            set;
        }
    }
}
