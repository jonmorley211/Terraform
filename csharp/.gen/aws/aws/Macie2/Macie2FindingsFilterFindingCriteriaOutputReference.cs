using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiClass(nativeType: typeof(aws.Macie2.Macie2FindingsFilterFindingCriteriaOutputReference), fullyQualifiedName: "aws.macie2.Macie2FindingsFilterFindingCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Macie2FindingsFilterFindingCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Macie2FindingsFilterFindingCriteriaOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2FindingsFilterFindingCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2FindingsFilterFindingCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCriterion")]
        public virtual void ResetCriterion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "criterionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Macie2.IMacie2FindingsFilterFindingCriteriaCriterion[]? CriterionInput
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2FindingsFilterFindingCriteriaCriterion[]?>();
        }

        [JsiiProperty(name: "criterion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.macie2.Macie2FindingsFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}")]
        public virtual aws.Macie2.IMacie2FindingsFilterFindingCriteriaCriterion[] Criterion
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2FindingsFilterFindingCriteriaCriterion[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.macie2.Macie2FindingsFilterFindingCriteria\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2FindingsFilterFindingCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2FindingsFilterFindingCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
