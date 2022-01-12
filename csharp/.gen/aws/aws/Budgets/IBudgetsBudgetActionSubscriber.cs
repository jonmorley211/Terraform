using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetActionSubscriber), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionSubscriber")]
    public interface IBudgetsBudgetActionSubscriber
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#address BudgetsBudgetAction#address}.</summary>
        [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
        string Address
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#subscription_type BudgetsBudgetAction#subscription_type}.</summary>
        [JsiiProperty(name: "subscriptionType", typeJson: "{\"primitive\":\"string\"}")]
        string SubscriptionType
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetActionSubscriber), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionSubscriber")]
        internal sealed class _Proxy : DeputyBase, aws.Budgets.IBudgetsBudgetActionSubscriber
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#address BudgetsBudgetAction#address}.</summary>
            [JsiiProperty(name: "address", typeJson: "{\"primitive\":\"string\"}")]
            public string Address
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#subscription_type BudgetsBudgetAction#subscription_type}.</summary>
            [JsiiProperty(name: "subscriptionType", typeJson: "{\"primitive\":\"string\"}")]
            public string SubscriptionType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
