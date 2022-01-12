using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfigOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetErrorTopic")]
        public virtual void ResetErrorTopic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSuccessTopic")]
        public virtual void ResetSuccessTopic()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "errorTopicInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ErrorTopicInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "successTopicInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SuccessTopicInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "errorTopic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ErrorTopic
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "successTopic", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SuccessTopic
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerEndpointConfigurationAsyncInferenceConfigOutputConfigNotificationConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
