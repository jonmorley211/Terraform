using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig")]
    public interface ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#s3_output_path SagemakerEndpointConfiguration#s3_output_path}.</summary>
        [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
        string S3OutputPath
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#kms_key_id SagemakerEndpointConfiguration#kms_key_id}.</summary>
        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? KmsKeyId
        {
            get
            {
                return null;
            }
        }

        /// <summary>notification_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#notification_config SagemakerEndpointConfiguration#notification_config}
        /// </remarks>
        [JsiiProperty(name: "notificationConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#s3_output_path SagemakerEndpointConfiguration#s3_output_path}.</summary>
            [JsiiProperty(name: "s3OutputPath", typeJson: "{\"primitive\":\"string\"}")]
            public string S3OutputPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#kms_key_id SagemakerEndpointConfiguration#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>notification_config block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#notification_config SagemakerEndpointConfiguration#notification_config}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notificationConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig? NotificationConfig
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig?>();
            }
        }
    }
}
