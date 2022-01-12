using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerUserProfileUserSettingsJupyterServerAppSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerUserProfileUserSettingsJupyterServerAppSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsJupyterServerAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsJupyterServerAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultResourceSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec\"}}]")]
        public virtual void PutDefaultResourceSpec(aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetLifecycleConfigArns")]
        public virtual void ResetLifecycleConfigArns()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpecOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpecOutputReference DefaultResourceSpec
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpecInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec? DefaultResourceSpecInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettingsDefaultResourceSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lifecycleConfigArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? LifecycleConfigArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiProperty(name: "lifecycleConfigArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] LifecycleConfigArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
