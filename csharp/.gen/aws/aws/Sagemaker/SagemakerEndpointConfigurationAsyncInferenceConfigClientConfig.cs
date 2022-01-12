using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiByValue(fqn: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig : aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#max_concurrent_invocations_per_instance SagemakerEndpointConfiguration#max_concurrent_invocations_per_instance}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentInvocationsPerInstance", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? MaxConcurrentInvocationsPerInstance
        {
            get;
            set;
        }
    }
}
