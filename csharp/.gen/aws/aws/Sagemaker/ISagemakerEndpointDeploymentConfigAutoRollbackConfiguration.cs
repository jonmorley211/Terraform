using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration")]
    public interface ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration
    {
        /// <summary>alarms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#alarms SagemakerEndpoint#alarms}
        /// </remarks>
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms[]? Alarms
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>alarms block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#alarms SagemakerEndpoint#alarms}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms[]? Alarms
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms[]?>();
            }
        }
    }
}
