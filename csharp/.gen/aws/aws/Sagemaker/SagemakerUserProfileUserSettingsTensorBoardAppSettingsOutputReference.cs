using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerUserProfileUserSettingsTensorBoardAppSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerUserProfileUserSettingsTensorBoardAppSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsTensorBoardAppSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsTensorBoardAppSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putDefaultResourceSpec", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}}]")]
        public virtual void PutDefaultResourceSpec(aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec)}, new object[]{@value});
        }

        [JsiiProperty(name: "defaultResourceSpec", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpecOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpecOutputReference DefaultResourceSpec
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpecOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "defaultResourceSpecInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec? DefaultResourceSpecInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettingsDefaultResourceSpec?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
