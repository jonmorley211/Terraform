using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationAsyncInferenceConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig\"}}]")]
        public virtual void PutClientConfig(aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOutputConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig\"}}]")]
        public virtual void PutOutputConfig(aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientConfig")]
        public virtual void ResetClientConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference ClientConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfigOutputReference>()!;
        }

        [JsiiProperty(name: "outputConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigOutputReference OutputConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigClientConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig? ClientConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigClientConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "outputConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig? OutputConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
