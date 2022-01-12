using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointDeploymentConfig), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfig")]
    public interface ISagemakerEndpointDeploymentConfig
    {
        /// <summary>blue_green_update_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#blue_green_update_policy SagemakerEndpoint#blue_green_update_policy}
        /// </remarks>
        [JsiiProperty(name: "blueGreenUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}")]
        aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy BlueGreenUpdatePolicy
        {
            get;
        }

        /// <summary>auto_rollback_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#auto_rollback_configuration SagemakerEndpoint#auto_rollback_configuration}
        /// </remarks>
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointDeploymentConfig), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointDeploymentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointDeploymentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>blue_green_update_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#blue_green_update_policy SagemakerEndpoint#blue_green_update_policy}
            /// </remarks>
            [JsiiProperty(name: "blueGreenUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}")]
            public aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy BlueGreenUpdatePolicy
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy>()!;
            }

            /// <summary>auto_rollback_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#auto_rollback_configuration SagemakerEndpoint#auto_rollback_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration?>();
            }
        }
    }
}
