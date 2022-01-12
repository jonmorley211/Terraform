using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.budgets.BudgetsBudgetActionDefinitionScpActionDefinition")]
    public class BudgetsBudgetActionDefinitionScpActionDefinition : aws.Budgets.IBudgetsBudgetActionDefinitionScpActionDefinition
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#policy_id BudgetsBudgetAction#policy_id}.</summary>
        [JsiiProperty(name: "policyId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string PolicyId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#target_ids BudgetsBudgetAction#target_ids}.</summary>
        [JsiiProperty(name: "targetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] TargetIds
        {
            get;
            set;
        }
    }
}
