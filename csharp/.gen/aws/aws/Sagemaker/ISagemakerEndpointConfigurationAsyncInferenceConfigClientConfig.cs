using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig")]
    public interface ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#max_concurrent_invocations_per_instance SagemakerEndpointConfiguration#max_concurrent_invocations_per_instance}.</summary>
        [JsiiProperty(name: "maxConcurrentInvocationsPerInstance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxConcurrentInvocationsPerInstance
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_endpoint_configuration#max_concurrent_invocations_per_instance SagemakerEndpointConfiguration#max_concurrent_invocations_per_instance}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "maxConcurrentInvocationsPerInstance", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxConcurrentInvocationsPerInstance
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
