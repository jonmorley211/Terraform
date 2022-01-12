using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader")]
    public class SagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader : aws.Sagemaker.ISagemakerEndpointConfigurationDataCaptureConfigCaptureContentTypeHeader
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#csv_content_types SagemakerEndpointConfiguration#csv_content_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "csvContentTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? CsvContentTypes
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#json_content_types SagemakerEndpointConfiguration#json_content_types}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "jsonContentTypes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? JsonContentTypes
        {
            get;
            set;
        }
    }
}
