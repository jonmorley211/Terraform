using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    #pragma warning disable CS8618

    /// <summary>AWS Budgets.</summary>
    [JsiiByValue(fqn: "aws.budgets.BudgetsBudgetActionConfig")]
    public class BudgetsBudgetActionConfig : aws.Budgets.IBudgetsBudgetActionConfig
    {
        /// <summary>action_threshold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_threshold BudgetsBudgetAction#action_threshold}
        /// </remarks>
        [JsiiProperty(name: "actionThreshold", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionActionThreshold\"}", isOverride: true)]
        public aws.Budgets.IBudgetsBudgetActionActionThreshold ActionThreshold
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_type BudgetsBudgetAction#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ActionType
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#approval_model BudgetsBudgetAction#approval_model}.</summary>
        [JsiiProperty(name: "approvalModel", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ApprovalModel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#budget_name BudgetsBudgetAction#budget_name}.</summary>
        [JsiiProperty(name: "budgetName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string BudgetName
        {
            get;
            set;
        }

        /// <summary>definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#definition BudgetsBudgetAction#definition}
        /// </remarks>
        [JsiiProperty(name: "definition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinition\"}", isOverride: true)]
        public aws.Budgets.IBudgetsBudgetActionDefinition Definition
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#execution_role_arn BudgetsBudgetAction#execution_role_arn}.</summary>
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ExecutionRoleArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#notification_type BudgetsBudgetAction#notification_type}.</summary>
        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string NotificationType
        {
            get;
            set;
        }

        /// <summary>subscriber block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#subscriber BudgetsBudgetAction#subscriber}
        /// </remarks>
        [JsiiProperty(name: "subscriber", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionSubscriber\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Budgets.IBudgetsBudgetActionSubscriber[] Subscriber
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#account_id BudgetsBudgetAction#account_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AccountId
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? Count
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true, isOverride: true)]
        public HashiCorp.Cdktf.TerraformProvider? Provider
        {
            get;
            set;
        }
    }
}
