using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerModelPrimaryContainerOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerModelPrimaryContainerOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerModelPrimaryContainerOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerModelPrimaryContainerOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelPrimaryContainerOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerModelPrimaryContainerOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putImageConfig", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerModelPrimaryContainerImageConfig\"}}]")]
        public virtual void PutImageConfig(aws.Sagemaker.ISagemakerModelPrimaryContainerImageConfig @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerModelPrimaryContainerImageConfig)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetContainerHostname")]
        public virtual void ResetContainerHostname()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetEnvironment")]
        public virtual void ResetEnvironment()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetImageConfig")]
        public virtual void ResetImageConfig()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMode")]
        public virtual void ResetMode()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetModelDataUrl")]
        public virtual void ResetModelDataUrl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "imageConfig", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelPrimaryContainerImageConfigOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerModelPrimaryContainerImageConfigOutputReference ImageConfig
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerModelPrimaryContainerImageConfigOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "containerHostnameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ContainerHostnameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "environmentInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? EnvironmentInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageConfigInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelPrimaryContainerImageConfig\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerModelPrimaryContainerImageConfig? ImageConfigInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerModelPrimaryContainerImageConfig?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "imageInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ImageInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "modelDataUrlInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ModelDataUrlInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "containerHostname", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ContainerHostname
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "environment", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Environment
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "image", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Image
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Mode
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "modelDataUrl", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ModelDataUrl
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerModelPrimaryContainer\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerModelPrimaryContainer? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerModelPrimaryContainer?>();
            set => SetInstanceProperty(value);
        }
    }
}
