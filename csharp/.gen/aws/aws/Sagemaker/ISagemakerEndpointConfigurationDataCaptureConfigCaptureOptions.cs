using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions")]
    public interface ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#capture_mode SagemakerEndpointConfiguration#capture_mode}.</summary>
        [JsiiProperty(name: "captureMode", typeJson: "{\"primitive\":\"string\"}")]
        string CaptureMode
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#capture_mode SagemakerEndpointConfiguration#capture_mode}.</summary>
            [JsiiProperty(name: "captureMode", typeJson: "{\"primitive\":\"string\"}")]
            public string CaptureMode
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
