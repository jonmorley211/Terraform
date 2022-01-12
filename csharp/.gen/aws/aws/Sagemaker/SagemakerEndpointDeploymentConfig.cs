using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointDeploymentConfig")]
    public class SagemakerEndpointDeploymentConfig : aws.Sagemaker.ISagemakerEndpointDeploymentConfig
    {
        /// <summary>blue_green_update_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#blue_green_update_policy SagemakerEndpoint#blue_green_update_policy}
        /// </remarks>
        [JsiiProperty(name: "blueGreenUpdatePolicy", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy\"}", isOverride: true)]
        public aws.Sagemaker.ISagemakerEndpointDeploymentConfigBlueGreenUpdatePolicy BlueGreenUpdatePolicy
        {
            get;
            set;
        }

        /// <summary>auto_rollback_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#auto_rollback_configuration SagemakerEndpoint#auto_rollback_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "autoRollbackConfiguration", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration? AutoRollbackConfiguration
        {
            get;
            set;
        }
    }
}
