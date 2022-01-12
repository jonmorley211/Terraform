using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions")]
    public class SagemakerEndpointConfigurationDataCaptureConfigCaptureOptions : aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureOptions
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#capture_mode SagemakerEndpointConfiguration#capture_mode}.</summary>
        [JsiiProperty(name: "captureMode", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string CaptureMode
        {
            get;
            set;
        }
    }
}
