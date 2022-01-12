using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTrafficRoutingConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration\"}}]")]
        public virtual void PutTrafficRoutingConfiguration(aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetMaximumExecutionTimeoutInSeconds")]
        public virtual void ResetMaximumExecutionTimeoutInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTerminationWaitInSeconds")]
        public virtual void ResetTerminationWaitInSeconds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "trafficRoutingConfiguration", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationOutputReference TrafficRoutingConfiguration
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "maximumExecutionTimeoutInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaximumExecutionTimeoutInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "terminationWaitInSecondsInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? TerminationWaitInSecondsInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trafficRoutingConfigurationInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration? TrafficRoutingConfigurationInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration?>();
        }

        [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaximumExecutionTimeoutInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "terminationWaitInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double TerminationWaitInSeconds
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
