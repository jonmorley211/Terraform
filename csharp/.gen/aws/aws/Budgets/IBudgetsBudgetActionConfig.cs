using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    /// <summary>AWS Budgets.</summary>
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetActionConfig), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionConfig")]
    public interface IBudgetsBudgetActionConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>action_threshold block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_threshold BudgetsBudgetAction#action_threshold}
        /// </remarks>
        [JsiiProperty(name: "actionThreshold", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionActionThreshold\"}")]
        aws.Budgets.IBudgetsBudgetActionActionThreshold ActionThreshold
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_type BudgetsBudgetAction#action_type}.</summary>
        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        string ActionType
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#approval_model BudgetsBudgetAction#approval_model}.</summary>
        [JsiiProperty(name: "approvalModel", typeJson: "{\"primitive\":\"string\"}")]
        string ApprovalModel
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#budget_name BudgetsBudgetAction#budget_name}.</summary>
        [JsiiProperty(name: "budgetName", typeJson: "{\"primitive\":\"string\"}")]
        string BudgetName
        {
            get;
        }

        /// <summary>definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#definition BudgetsBudgetAction#definition}
        /// </remarks>
        [JsiiProperty(name: "definition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinition\"}")]
        aws.Budgets.IBudgetsBudgetActionDefinition Definition
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#execution_role_arn BudgetsBudgetAction#execution_role_arn}.</summary>
        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionRoleArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#notification_type BudgetsBudgetAction#notification_type}.</summary>
        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}")]
        string NotificationType
        {
            get;
        }

        /// <summary>subscriber block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#subscriber BudgetsBudgetAction#subscriber}
        /// </remarks>
        [JsiiProperty(name: "subscriber", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionSubscriber\"},\"kind\":\"array\"}}")]
        aws.Budgets.IBudgetsBudgetActionSubscriber[] Subscriber
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#account_id BudgetsBudgetAction#account_id}.</summary>
        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AccountId
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Budgets.</summary>
        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetActionConfig), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Budgets.IBudgetsBudgetActionConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action_threshold block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_threshold BudgetsBudgetAction#action_threshold}
            /// </remarks>
            [JsiiProperty(name: "actionThreshold", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionActionThreshold\"}")]
            public aws.Budgets.IBudgetsBudgetActionActionThreshold ActionThreshold
            {
                get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionActionThreshold>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#action_type BudgetsBudgetAction#action_type}.</summary>
            [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ActionType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#approval_model BudgetsBudgetAction#approval_model}.</summary>
            [JsiiProperty(name: "approvalModel", typeJson: "{\"primitive\":\"string\"}")]
            public string ApprovalModel
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#budget_name BudgetsBudgetAction#budget_name}.</summary>
            [JsiiProperty(name: "budgetName", typeJson: "{\"primitive\":\"string\"}")]
            public string BudgetName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#definition BudgetsBudgetAction#definition}
            /// </remarks>
            [JsiiProperty(name: "definition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinition\"}")]
            public aws.Budgets.IBudgetsBudgetActionDefinition Definition
            {
                get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionDefinition>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#execution_role_arn BudgetsBudgetAction#execution_role_arn}.</summary>
            [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#notification_type BudgetsBudgetAction#notification_type}.</summary>
            [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}")]
            public string NotificationType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>subscriber block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#subscriber BudgetsBudgetAction#subscriber}
            /// </remarks>
            [JsiiProperty(name: "subscriber", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionSubscriber\"},\"kind\":\"array\"}}")]
            public aws.Budgets.IBudgetsBudgetActionSubscriber[] Subscriber
            {
                get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionSubscriber[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#account_id BudgetsBudgetAction#account_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AccountId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
