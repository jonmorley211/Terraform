using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    [JsiiByValue(fqn: "aws.budgets.BudgetsBudgetActionDefinition")]
    public class BudgetsBudgetActionDefinition : aws.Budgets.IBudgetsBudgetActionDefinition
    {
        /// <summary>iam_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#iam_action_definition BudgetsBudgetAction#iam_action_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iamActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionIamActionDefinition\"}", isOptional: true, isOverride: true)]
        public aws.Budgets.IBudgetsBudgetActionDefinitionIamActionDefinition? IamActionDefinition
        {
            get;
            set;
        }

        /// <summary>scp_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#scp_action_definition BudgetsBudgetAction#scp_action_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scpActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionScpActionDefinition\"}", isOptional: true, isOverride: true)]
        public aws.Budgets.IBudgetsBudgetActionDefinitionScpActionDefinition? ScpActionDefinition
        {
            get;
            set;
        }

        /// <summary>ssm_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#ssm_action_definition BudgetsBudgetAction#ssm_action_definition}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ssmActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionSsmActionDefinition\"}", isOptional: true, isOverride: true)]
        public aws.Budgets.IBudgetsBudgetActionDefinitionSsmActionDefinition? SsmActionDefinition
        {
            get;
            set;
        }
    }
}
