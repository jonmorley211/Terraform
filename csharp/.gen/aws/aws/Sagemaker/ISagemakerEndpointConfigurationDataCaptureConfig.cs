using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationDataCaptureConfig), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfig")]
    public interface ISagemakerEndpointConfigurationDataCaptureConfig
    {
        /// <summary>capture_options block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#capture_options SagemakerEndpointConfiguration#capture_options}
        /// </remarks>
        [JsiiProperty(name: "captureOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions\"},\"kind\":\"array\"}}")]
        aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions[] CaptureOptions
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#destination_s3_uri SagemakerEndpointConfiguration#destination_s3_uri}.</summary>
        [JsiiProperty(name: "destinationS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        string DestinationS3Uri
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#initial_sampling_percentage SagemakerEndpointConfiguration#initial_sampling_percentage}.</summary>
        [JsiiProperty(name: "initialSamplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
        double InitialSamplingPercentage
        {
            get;
        }

        /// <summary>capture_content_type_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#capture_content_type_header SagemakerEndpointConfiguration#capture_content_type_header}
        /// </remarks>
        [JsiiProperty(name: "captureContentTypeHeader", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#enable_capture SagemakerEndpointConfiguration#enable_capture}.</summary>
        [JsiiProperty(name: "enableCapture", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? EnableCapture
        {
            get
            {
                return null;
            }
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

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationDataCaptureConfig), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>capture_options block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#capture_options SagemakerEndpointConfiguration#capture_options}
            /// </remarks>
            [JsiiProperty(name: "captureOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions\"},\"kind\":\"array\"}}")]
            public aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions[] CaptureOptions
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#destination_s3_uri SagemakerEndpointConfiguration#destination_s3_uri}.</summary>
            [JsiiProperty(name: "destinationS3Uri", typeJson: "{\"primitive\":\"string\"}")]
            public string DestinationS3Uri
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#initial_sampling_percentage SagemakerEndpointConfiguration#initial_sampling_percentage}.</summary>
            [JsiiProperty(name: "initialSamplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
            public double InitialSamplingPercentage
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>capture_content_type_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#capture_content_type_header SagemakerEndpointConfiguration#capture_content_type_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "captureContentTypeHeader", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeader
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#enable_capture SagemakerEndpointConfiguration#enable_capture}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "enableCapture", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? EnableCapture
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#kms_key_id SagemakerEndpointConfiguration#kms_key_id}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? KmsKeyId
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
