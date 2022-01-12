using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    [JsiiInterface(nativeType: typeof(IBudgetsBudgetActionDefinition), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionDefinition")]
    public interface IBudgetsBudgetActionDefinition
    {
        /// <summary>iam_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#iam_action_definition BudgetsBudgetAction#iam_action_definition}
        /// </remarks>
        [JsiiProperty(name: "iamActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionIamActionDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Budgets.IBudgetsBudgetActionDefinitionIamActionDefinition? IamActionDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>scp_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#scp_action_definition BudgetsBudgetAction#scp_action_definition}
        /// </remarks>
        [JsiiProperty(name: "scpActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionScpActionDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Budgets.IBudgetsBudgetActionDefinitionScpActionDefinition? ScpActionDefinition
        {
            get
            {
                return null;
            }
        }

        /// <summary>ssm_action_definition block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#ssm_action_definition BudgetsBudgetAction#ssm_action_definition}
        /// </remarks>
        [JsiiProperty(name: "ssmActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionSsmActionDefinition\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Budgets.IBudgetsBudgetActionDefinitionSsmActionDefinition? SsmActionDefinition
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IBudgetsBudgetActionDefinition), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionDefinition")]
        internal sealed class _Proxy : DeputyBase, aws.Budgets.IBudgetsBudgetActionDefinition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>iam_action_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#iam_action_definition BudgetsBudgetAction#iam_action_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iamActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionIamActionDefinition\"}", isOptional: true)]
            public aws.Budgets.IBudgetsBudgetActionDefinitionIamActionDefinition? IamActionDefinition
            {
                get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionDefinitionIamActionDefinition?>();
            }

            /// <summary>scp_action_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#scp_action_definition BudgetsBudgetAction#scp_action_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scpActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionScpActionDefinition\"}", isOptional: true)]
            public aws.Budgets.IBudgetsBudgetActionDefinitionScpActionDefinition? ScpActionDefinition
            {
                get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionDefinitionScpActionDefinition?>();
            }

            /// <summary>ssm_action_definition block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action#ssm_action_definition BudgetsBudgetAction#ssm_action_definition}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ssmActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionSsmActionDefinition\"}", isOptional: true)]
            public aws.Budgets.IBudgetsBudgetActionDefinitionSsmActionDefinition? SsmActionDefinition
            {
                get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionDefinitionSsmActionDefinition?>();
            }
        }
    }
}
