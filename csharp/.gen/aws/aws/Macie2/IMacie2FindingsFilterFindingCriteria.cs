using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiInterface(nativeType: typeof(IMacie2FindingsFilterFindingCriteria), fullyQualifiedName: "aws.macie2.Macie2FindingsFilterFindingCriteria")]
    public interface IMacie2FindingsFilterFindingCriteria
    {
        /// <summary>criterion block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#criterion Macie2FindingsFilter#criterion}
        /// </remarks>
        [JsiiProperty(name: "criterion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Macie2.IMacie2FindingsFilterFindingCriteriaCriterion[]? Criterion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2FindingsFilterFindingCriteria), fullyQualifiedName: "aws.macie2.Macie2FindingsFilterFindingCriteria")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2.IMacie2FindingsFilterFindingCriteria
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>criterion block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_findings_filter#criterion Macie2FindingsFilter#criterion}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "criterion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Macie2.IMacie2FindingsFilterFindingCriteriaCriterion[]? Criterion
            {
                get => GetInstanceProperty<aws.Macie2.IMacie2FindingsFilterFindingCriteriaCriterion[]?>();
            }
        }
    }
}
