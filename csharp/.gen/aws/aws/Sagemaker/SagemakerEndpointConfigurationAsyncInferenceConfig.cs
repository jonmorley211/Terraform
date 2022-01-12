using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfig")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfig : aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfig
    {
        /// <summary>output_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#output_config SagemakerEndpointConfiguration#output_config}
        /// </remarks>
        [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig\"}", isOverride: true)]
        public aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig OutputConfig
        {
            get;
            set;
        }

        /// <summary>client_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#client_config SagemakerEndpointConfiguration#client_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig? ClientConfig
        {
            get;
            set;
        }
    }
}
