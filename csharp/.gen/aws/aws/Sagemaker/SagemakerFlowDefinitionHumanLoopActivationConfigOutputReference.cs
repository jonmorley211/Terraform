using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerFlowDefinitionHumanLoopActivationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putHumanLoopActivationConditionsConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig\"}}]")]
        public virtual void PutHumanLoopActivationConditionsConfig(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetHumanLoopActivationConditionsConfig")]
        public virtual void ResetHumanLoopActivationConditionsConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "humanLoopActivationConditionsConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfigOutputReference HumanLoopActivationConditionsConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "humanLoopActivationConditionsConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig? HumanLoopActivationConditionsConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfigHumanLoopActivationConditionsConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerFlowDefinitionHumanLoopActivationConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerFlowDefinitionHumanLoopActivationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
