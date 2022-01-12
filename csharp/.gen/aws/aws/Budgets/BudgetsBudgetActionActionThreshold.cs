using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgets.BudgetsBudgetActionActionThreshold")]
    public class BudgetsBudgetActionActionThreshold : aws.Budgets.IBudgetsBudgetActionActionThreshold
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_threshold_type BudgetsBudgetAction#action_threshold_type}.</summary>
        [JsiiProperty(name: "actionThresholdType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ActionThresholdType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_threshold_value BudgetsBudgetAction#action_threshold_value}.</summary>
        [JsiiProperty(name: "actionThresholdValue", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double ActionThresholdValue
        {
            get;
            set;
        }
    }
}
