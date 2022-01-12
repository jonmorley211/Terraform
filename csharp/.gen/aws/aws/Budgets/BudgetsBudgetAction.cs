using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action aws_budgets_budget_action}.</summary>
    [JsiiClass(nativeType: typeof(aws.Budgets.BudgetsBudgetAction), fullyQualifiedName: "aws.budgets.BudgetsBudgetAction", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionConfig\"}}]")]
    public class BudgetsBudgetAction : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/budgets_budget_action aws_budgets_budget_action} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public BudgetsBudgetAction(Constructs.Construct scope, string id, aws.Budgets.IBudgetsBudgetActionConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetAction(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetAction(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putActionThreshold", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionActionThreshold\"}}]")]
        public virtual void PutActionThreshold(aws.Budgets.IBudgetsBudgetActionActionThreshold @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Budgets.IBudgetsBudgetActionActionThreshold)}, new object[]{@value});
        }

        [JsiiMethod(name: "putDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinition\"}}]")]
        public virtual void PutDefinition(aws.Budgets.IBudgetsBudgetActionDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Budgets.IBudgetsBudgetActionDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccountId")]
        public virtual void ResetAccountId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Budgets.BudgetsBudgetAction))!;

        [JsiiProperty(name: "actionId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "actionThreshold", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionActionThresholdOutputReference\"}")]
        public virtual aws.Budgets.BudgetsBudgetActionActionThresholdOutputReference ActionThreshold
        {
            get => GetInstanceProperty<aws.Budgets.BudgetsBudgetActionActionThresholdOutputReference>()!;
        }

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "definition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionOutputReference\"}")]
        public virtual aws.Budgets.BudgetsBudgetActionDefinitionOutputReference Definition
        {
            get => GetInstanceProperty<aws.Budgets.BudgetsBudgetActionDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionThresholdInput", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionActionThreshold\"}", isOptional: true)]
        public virtual aws.Budgets.IBudgetsBudgetActionActionThreshold? ActionThresholdInput
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionActionThreshold?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "actionTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ActionTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "approvalModelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ApprovalModelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "budgetNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BudgetNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "definitionInput", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinition\"}", isOptional: true)]
        public virtual aws.Budgets.IBudgetsBudgetActionDefinition? DefinitionInput
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleArnInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleArnInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notificationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NotificationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subscriberInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionSubscriber\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Budgets.IBudgetsBudgetActionSubscriber[]? SubscriberInput
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionSubscriber[]?>();
        }

        [JsiiProperty(name: "accountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "actionType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ActionType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "approvalModel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ApprovalModel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "budgetName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BudgetName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "executionRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRoleArn
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "notificationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NotificationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subscriber", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionSubscriber\"},\"kind\":\"array\"}}")]
        public virtual aws.Budgets.IBudgetsBudgetActionSubscriber[] Subscriber
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionSubscriber[]>()!;
            set => SetInstanceProperty(value);
        }
    }
}
