using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    [JsiiClass(nativeType: typeof(aws.Budgets.BudgetsBudgetActionActionThresholdOutputReference), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionActionThresholdOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BudgetsBudgetActionActionThresholdOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public BudgetsBudgetActionActionThresholdOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetActionActionThresholdOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetActionActionThresholdOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionThresholdTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionThresholdTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionThresholdValueInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ActionThresholdValueInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "actionThresholdType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionThresholdType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "actionThresholdValue", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ActionThresholdValue
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionActionThreshold\"}", isOptional: true)]
        public virtual aws.Budgets.IBudgetsBudgetActionActionThreshold? InternalValue
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionActionThreshold?>();
            set => SetInstanceProperty(value);
        }
    }
}
