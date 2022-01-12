using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetActionActionThreshold), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionActionThreshold")]
    public interface IBudgetsBudgetActionActionThreshold
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_threshold_type BudgetsBudgetAction#action_threshold_type}.</summary>
        [JsiiProperty(name: "actionThresholdType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionThresholdType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_threshold_value BudgetsBudgetAction#action_threshold_value}.</summary>
        [JsiiProperty(name: "actionThresholdValue", typeJson: "{\"primitive\":\"number\"}")]
        double ActionThresholdValue
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetActionActionThreshold), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionActionThreshold")]
        internal sealed class _Proxy : DeputyBase, aws.Budgets.IBudgetsBudgetActionActionThreshold
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_threshold_type BudgetsBudgetAction#action_threshold_type}.</summary>
            [JsiiProperty(name: "actionThresholdType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionThresholdType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_threshold_value BudgetsBudgetAction#action_threshold_value}.</summary>
            [JsiiProperty(name: "actionThresholdValue", typeJson: "{\"primitive\":\"number\"}")]
            public double ActionThresholdValue
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
