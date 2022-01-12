using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig : aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#error_topic SagemakerEndpointConfiguration#error_topic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "errorTopic", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ErrorTopic
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#success_topic SagemakerEndpointConfiguration#success_topic}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "successTopic", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SuccessTopic
        {
            get;
            set;
        }
    }
}
