using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy")]
    public class SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy : aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy
    {
        /// <summary>traffic_routing_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#traffic_routing_configuration SagemakerEndpoint#traffic_routing_configuration}
        /// </remarks>
        [JsiiProperty(name: "trafficRoutingConfiguration", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration\"}", isOverride: true)]
        public aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration TrafficRoutingConfiguration
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#maximum_execution_timeout_in_seconds SagemakerEndpoint#maximum_execution_timeout_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maximumExecutionTimeoutInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaximumExecutionTimeoutInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#termination_wait_in_seconds SagemakerEndpoint#termination_wait_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "terminationWaitInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? TerminationWaitInSeconds
        {
            get;
            set;
        }
    }
}
