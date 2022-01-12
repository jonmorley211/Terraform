using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgets.BudgetsBudgetActionSubscriber")]
    public class BudgetsBudgetActionSubscriber : aws.Budgets.IBudgetsBudgetActionSubscriber
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#address BudgetsBudgetAction#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Address
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#subscription_type BudgetsBudgetAction#subscription_type}.</summary>
        [JsiiProperty(name: "subscriptionType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string SubscriptionType
        {
            get;
            set;
        }
    }
}
