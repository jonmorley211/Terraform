using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Guardduty
{
    [JsiiClass(nativeType: typeof(aws.Guardduty.GuarddutyFilterFindingCriteriaOutputReference), fullyQualifiedName: "aws.guardduty.GuarddutyFilterFindingCriteriaOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class GuarddutyFilterFindingCriteriaOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public GuarddutyFilterFindingCriteriaOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyFilterFindingCriteriaOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected GuarddutyFilterFindingCriteriaOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "criterionInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.guardduty.GuarddutyFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Guardduty.IGuarddutyFilterFindingCriteriaCriterion[]? CriterionInput
        {
            get => GetInstanceProperty<aws.Guardduty.IGuarddutyFilterFindingCriteriaCriterion[]?>();
        }

        [JsiiProperty(name: "criterion", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.guardduty.GuarddutyFilterFindingCriteriaCriterion\"},\"kind\":\"array\"}}")]
        public virtual aws.Guardduty.IGuarddutyFilterFindingCriteriaCriterion[] Criterion
        {
            get => GetInstanceProperty<aws.Guardduty.IGuarddutyFilterFindingCriteriaCriterion[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.guardduty.GuarddutyFilterFindingCriteria\"}", isOptional: true)]
        public virtual aws.Guardduty.IGuarddutyFilterFindingCriteria? InternalValue
        {
            get => GetInstanceProperty<aws.Guardduty.IGuarddutyFilterFindingCriteria?>();
            set => SetInstanceProperty(value);
        }
    }
}
