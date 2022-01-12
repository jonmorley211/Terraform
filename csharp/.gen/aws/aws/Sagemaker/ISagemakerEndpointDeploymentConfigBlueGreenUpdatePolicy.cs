using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy")]
    public interface ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy
    {
        /// <summary>traffic_routing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#traffic_routing_configuration SagemakerEndpoint#traffic_routing_configuration}
        /// </remarks>
        [JsiiProperty(name: "trafficRoutingConfiguration", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration\"}")]
        aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration TrafficRoutingConfiguration
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#maximum_execution_timeout_in_seconds SagemakerEndpoint#maximum_execution_timeout_in_seconds}.</summary>
        [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaximumExecutionTimeoutInSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#termination_wait_in_seconds SagemakerEndpoint#termination_wait_in_seconds}.</summary>
        [JsiiProperty(name: "terminationWaitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TerminationWaitInSeconds
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>traffic_routing_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#traffic_routing_configuration SagemakerEndpoint#traffic_routing_configuration}
            /// </remarks>
            [JsiiProperty(name: "trafficRoutingConfiguration", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration\"}")]
            public aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration TrafficRoutingConfiguration
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#maximum_execution_timeout_in_seconds SagemakerEndpoint#maximum_execution_timeout_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaximumExecutionTimeoutInSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#termination_wait_in_seconds SagemakerEndpoint#termination_wait_in_seconds}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "terminationWaitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TerminationWaitInSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
