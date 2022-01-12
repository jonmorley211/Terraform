using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiInterface(nativeType: typeof(IGuarddutyFilterFindingCriteria), fullyQualifiedName: "aws.guardduty.GuarddutyFilterFindingCriteria")]
    public interface IGuarddutyFilterFindingCriteria
    {
        /// <summary>criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#criterion GuarddutyFilter#criterion}
        /// </remarks>
        [JsiiProperty(name: "criterion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.guardduty.GuarddutyFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}")]
        aws.Guardduty.IGuarddutyFilterFindingCriteriaCriterion[] Criterion
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IGuarddutyFilterFindingCriteria), fullyQualifiedName: "aws.guardduty.GuarddutyFilterFindingCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.Guardduty.IGuarddutyFilterFindingCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>criterion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/guardduty_filter#criterion GuarddutyFilter#criterion}
            /// </remarks>
            [JsiiProperty(name: "criterion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.guardduty.GuarddutyFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}")]
            public aws.Guardduty.IGuarddutyFilterFindingCriteriaCriterion[] Criterion
            {
                get => GetInstanceProperty<aws.Guardduty.IGuarddutyFilterFindingCriteriaCriterion[]>()!;
            }
        }
    }
}
