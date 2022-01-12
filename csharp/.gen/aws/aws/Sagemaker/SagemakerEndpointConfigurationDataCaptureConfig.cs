using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfig")]
    public class SagemakerEndpointConfigurationDataCaptureConfig : aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfig
    {
        /// <summary>capture_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#capture_options SagemakerEndpointConfiguration#capture_options}
        /// </remarks>
        [JsiiProperty(name: "captureOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions\"},\"kind\":\"array\"}}", isOverride: true)]
        public aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions[] CaptureOptions
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#destination_s3_uri SagemakerEndpointConfiguration#destination_s3_uri}.</summary>
        [JsiiProperty(name: "destinationS3Uri", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DestinationS3Uri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#initial_sampling_percentage SagemakerEndpointConfiguration#initial_sampling_percentage}.</summary>
        [JsiiProperty(name: "initialSamplingPercentage", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double InitialSamplingPercentage
        {
            get;
            set;
        }

        /// <summary>capture_content_type_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#capture_content_type_header SagemakerEndpointConfiguration#capture_content_type_header}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "captureContentTypeHeader", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#enable_capture SagemakerEndpointConfiguration#enable_capture}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableCapture", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnableCapture
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
    }
}
