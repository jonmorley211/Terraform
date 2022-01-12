using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointDeploymentConfigAutoRollbackConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAlarms")]
        public virtual void ResetAlarms()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "alarmsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms[]? AlarmsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms[]?>();
        }

        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms\"},\"kind\":\"array\"}}")]
        public virtual aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms[] Alarms
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
