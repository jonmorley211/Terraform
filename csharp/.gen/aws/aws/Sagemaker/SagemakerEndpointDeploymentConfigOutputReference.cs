using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerEndpointDeploymentConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerEndpointDeploymentConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerEndpointDeploymentConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointDeploymentConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointDeploymentConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAutoRollbackConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}}]")]
        public virtual void PutAutoRollbackConfiguration(aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "putBlueGreenUpdatePolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}}]")]
        public virtual void PutBlueGreenUpdatePolicy(aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAutoRollbackConfiguration")]
        public virtual void ResetAutoRollbackConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference AutoRollbackConfiguration
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "blueGreenUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference BlueGreenUpdatePolicy
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfigurationInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfigurationInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blueGreenUpdatePolicyInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy? BlueGreenUpdatePolicyInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointDeploymentConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
