using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfiguration")]
    public class SagemakerEndpointDeploymentConfigAutoRollbackConfiguration : aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfiguration
    {
        /// <summary>alarms block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#alarms SagemakerEndpoint#alarms}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "alarms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms[]? Alarms
        {
            get;
            set;
        }
    }
}
