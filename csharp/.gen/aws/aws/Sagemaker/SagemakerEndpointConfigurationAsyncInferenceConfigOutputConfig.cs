using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig : aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#s3_output_path SagemakerEndpointConfiguration#s3_output_path}.</summary>
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string S3OutputPath
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#kms_key_id SagemakerEndpointConfiguration#kms_key_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? KmsKeyId
        {
            get;
            set;
        }

        /// <summary>notification_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#notification_config SagemakerEndpointConfiguration#notification_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "notificationConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig
        {
            get;
            set;
        }
    }
}
