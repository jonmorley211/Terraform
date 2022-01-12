using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetMaxConcurrentInvocationsPerInstance")]
        public virtual void ResetMaxConcurrentInvocationsPerInstance()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "maxConcurrentInvocationsPerInstanceInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? MaxConcurrentInvocationsPerInstanceInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "maxConcurrentInvocationsPerInstance", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double MaxConcurrentInvocationsPerInstance
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
