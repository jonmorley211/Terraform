using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerUserProfileUserSettingsOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerUserProfileUserSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerUserProfileUserSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerUserProfileUserSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJupyterServerAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettings\"}}]")]
        public virtual void PutJupyterServerAppSettings(aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKernelGatewayAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettings\"}}]")]
        public virtual void PutKernelGatewayAppSettings(aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSharingSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsSharingSettings\"}}]")]
        public virtual void PutSharingSettings(aws.Sagemaker.ISagemakerUserProfileUserSettingsSharingSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerUserProfileUserSettingsSharingSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTensorBoardAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettings\"}}]")]
        public virtual void PutTensorBoardAppSettings(aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetJupyterServerAppSettings")]
        public virtual void ResetJupyterServerAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKernelGatewayAppSettings")]
        public virtual void ResetKernelGatewayAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSecurityGroups")]
        public virtual void ResetSecurityGroups()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSharingSettings")]
        public virtual void ResetSharingSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTensorBoardAppSettings")]
        public virtual void ResetTensorBoardAppSettings()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsOutputReference JupyterServerAppSettings
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsOutputReference KernelGatewayAppSettings
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsSharingSettingsOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerUserProfileUserSettingsSharingSettingsOutputReference SharingSettings
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerUserProfileUserSettingsSharingSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsOutputReference TensorBoardAppSettings
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jupyterServerAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings? JupyterServerAppSettingsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelGatewayAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettingsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharingSettingsInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsSharingSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsSharingSettings? SharingSettingsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsSharingSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tensorBoardAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings? TensorBoardAppSettingsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings?>();
        }

        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ExecutionRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerUserProfileUserSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
