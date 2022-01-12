using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerUserProfileUserSettingsKernelGatewayAppSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerUserProfileUserSettingsKernelGatewayAppSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsKernelGatewayAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsKernelGatewayAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultResourceSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}}]")]
        public virtual void PutDefaultResourceSpec(aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomImage")]
        public virtual void ResetCustomImage()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLifecycleConfigArns")]
        public virtual void ResetLifecycleConfigArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpecOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpecOutputReference DefaultResourceSpec
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customImageInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage[]? CustomImageInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpecInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec? DefaultResourceSpecInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsDefaultResourceSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfigArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LifecycleConfigArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "customImage", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage\"},\"kind\":\"array\"}}")]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage[] CustomImage
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettingsCustomImage[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LifecycleConfigArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
