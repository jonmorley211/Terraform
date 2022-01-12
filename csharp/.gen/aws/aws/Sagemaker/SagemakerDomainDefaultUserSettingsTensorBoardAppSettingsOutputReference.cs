using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultResourceSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}}]")]
        public virtual void PutDefaultResourceSpec(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetDefaultResourceSpec")]
        public virtual void ResetDefaultResourceSpec()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpecOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpecOutputReference DefaultResourceSpec
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpecInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpecInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettingsDefaultResourceSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
