using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Budgets
{
    [JsiiClass(nativeType: typeof(aws.Budgets.BudgetsBudgetActionDefinitionOutputReference), fullyQualifiedName: "aws.budgets.BudgetsBudgetActionDefinitionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class BudgetsBudgetActionDefinitionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public BudgetsBudgetActionDefinitionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetActionDefinitionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected BudgetsBudgetActionDefinitionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIamActionDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionIamActionDefinition\"}}]")]
        public virtual void PutIamActionDefinition(aws.Budgets.IBudgetsBudgetActionDefinitionIamActionDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Budgets.IBudgetsBudgetActionDefinitionIamActionDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putScpActionDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionScpActionDefinition\"}}]")]
        public virtual void PutScpActionDefinition(aws.Budgets.IBudgetsBudgetActionDefinitionScpActionDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Budgets.IBudgetsBudgetActionDefinitionScpActionDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSsmActionDefinition", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionSsmActionDefinition\"}}]")]
        public virtual void PutSsmActionDefinition(aws.Budgets.IBudgetsBudgetActionDefinitionSsmActionDefinition @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Budgets.IBudgetsBudgetActionDefinitionSsmActionDefinition)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIamActionDefinition")]
        public virtual void ResetIamActionDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetScpActionDefinition")]
        public virtual void ResetScpActionDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSsmActionDefinition")]
        public virtual void ResetSsmActionDefinition()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "iamActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionIamActionDefinitionOutputReference\"}")]
        public virtual aws.Budgets.BudgetsBudgetActionDefinitionIamActionDefinitionOutputReference IamActionDefinition
        {
            get => GetInstanceProperty<aws.Budgets.BudgetsBudgetActionDefinitionIamActionDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "scpActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionScpActionDefinitionOutputReference\"}")]
        public virtual aws.Budgets.BudgetsBudgetActionDefinitionScpActionDefinitionOutputReference ScpActionDefinition
        {
            get => GetInstanceProperty<aws.Budgets.BudgetsBudgetActionDefinitionScpActionDefinitionOutputReference>()!;
        }

        [JsiiProperty(name: "ssmActionDefinition", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionSsmActionDefinitionOutputReference\"}")]
        public virtual aws.Budgets.BudgetsBudgetActionDefinitionSsmActionDefinitionOutputReference SsmActionDefinition
        {
            get => GetInstanceProperty<aws.Budgets.BudgetsBudgetActionDefinitionSsmActionDefinitionOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "iamActionDefinitionInput", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionIamActionDefinition\"}", isOptional: true)]
        public virtual aws.Budgets.IBudgetsBudgetActionDefinitionIamActionDefinition? IamActionDefinitionInput
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionDefinitionIamActionDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "scpActionDefinitionInput", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionScpActionDefinition\"}", isOptional: true)]
        public virtual aws.Budgets.IBudgetsBudgetActionDefinitionScpActionDefinition? ScpActionDefinitionInput
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionDefinitionScpActionDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ssmActionDefinitionInput", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinitionSsmActionDefinition\"}", isOptional: true)]
        public virtual aws.Budgets.IBudgetsBudgetActionDefinitionSsmActionDefinition? SsmActionDefinitionInput
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionDefinitionSsmActionDefinition?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.budgets.BudgetsBudgetActionDefinition\"}", isOptional: true)]
        public virtual aws.Budgets.IBudgetsBudgetActionDefinition? InternalValue
        {
            get => GetInstanceProperty<aws.Budgets.IBudgetsBudgetActionDefinition?>();
            set => SetInstanceProperty(value);
        }
    }
}
