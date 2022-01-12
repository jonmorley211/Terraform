using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultResourceSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}}]")]
        public virtual void PutDefaultResourceSpec(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomImage")]
        public virtual void ResetCustomImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDefaultResourceSpec")]
        public virtual void ResetDefaultResourceSpec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleConfigArns")]
        public virtual void ResetLifecycleConfigArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpecOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpecOutputReference DefaultResourceSpec
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customImageInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage[]? CustomImageInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpecInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpecInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsDefaultResourceSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfigArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LifecycleConfigArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "customImage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}")]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage[] CustomImage
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsCustomImage[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LifecycleConfigArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
