using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerEndpointConfigurationDataCaptureConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerEndpointConfigurationDataCaptureConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerEndpointConfigurationDataCaptureConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationDataCaptureConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationDataCaptureConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCaptureContentTypeHeader", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader\"}}]")]
        public virtual void PutCaptureContentTypeHeader(aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCaptureContentTypeHeader")]
        public virtual void ResetCaptureContentTypeHeader()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnableCapture")]
        public virtual void ResetEnableCapture()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyId")]
        public virtual void ResetKmsKeyId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "captureContentTypeHeader", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeaderOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeaderOutputReference CaptureContentTypeHeader
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeaderOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "captureContentTypeHeaderInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader? CaptureContentTypeHeaderInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "captureOptionsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions[]? CaptureOptionsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "destinationS3UriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DestinationS3UriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "enableCaptureInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnableCaptureInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "initialSamplingPercentageInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? InitialSamplingPercentageInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "captureOptions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions\"},\"kind\":\"array\"}}")]
        public virtual aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions[] CaptureOptions
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "destinationS3Uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DestinationS3Uri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "enableCapture", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object EnableCapture
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "initialSamplingPercentage", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double InitialSamplingPercentage
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
