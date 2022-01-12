using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms")]
    public class SagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms : aws.Sagemaker.ISagemakerEndpointDeploymentConfigAutoRollbackConfigurationAlarms
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint#alarm_name SagemakerEndpoint#alarm_name}.</summary>
        [JsiiProperty(name: "alarmName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AlarmName
        {
            get;
            set;
        }
    }
}
