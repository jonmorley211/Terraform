using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration")]
    public interface ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#type SagemakerEndpoint#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#wait_interval_in_seconds SagemakerEndpoint#wait_interval_in_seconds}.</summary>
        [JsiiProperty(name: "waitIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
        double WaitIntervalInSeconds
        {
            get;
        }

        /// <summary>canary_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#canary_size SagemakerEndpoint#canary_size}
        /// </remarks>
        [JsiiProperty(name: "canarySize", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize? CanarySize
        {
            get
            {
                return null;
            }
        }

        /// <summary>linear_step_size block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#linear_step_size SagemakerEndpoint#linear_step_size}
        /// </remarks>
        [JsiiProperty(name: "linearStepSize", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize? LinearStepSize
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#type SagemakerEndpoint#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#wait_interval_in_seconds SagemakerEndpoint#wait_interval_in_seconds}.</summary>
            [JsiiProperty(name: "waitIntervalInSeconds", typeJson: "{\"primitive\":\"number\"}")]
            public double WaitIntervalInSeconds
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>canary_size block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#canary_size SagemakerEndpoint#canary_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "canarySize", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize? CanarySize
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationCanarySize?>();
            }

            /// <summary>linear_step_size block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#linear_step_size SagemakerEndpoint#linear_step_size}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "linearStepSize", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize? LinearStepSize
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicyTrafficRoutingConfigurationLinearStepSize?>();
            }
        }
    }
}
