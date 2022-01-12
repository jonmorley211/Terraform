using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiClass(nativeType: typeof(aws.Sagemaker.SagemakerDomainDefaultUserSettingsOutputReference), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SagemakerDomainDefaultUserSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SagemakerDomainDefaultUserSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SagemakerDomainDefaultUserSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putJupyterServerAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettings\"}}]")]
        public virtual void PutJupyterServerAppSettings(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putKernelGatewayAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings\"}}]")]
        public virtual void PutKernelGatewayAppSettings(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSharingSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsSharingSettings\"}}]")]
        public virtual void PutSharingSettings(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTensorBoardAppSettings", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings\"}}]")]
        public virtual void PutTensorBoardAppSettings(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings)}, new object[]{@value});
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

        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettingsOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettingsOutputReference JupyterServerAppSettings
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference KernelGatewayAppSettings
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference SharingSettings
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerDomainDefaultUserSettingsSharingSettingsOutputReference>()!;
        }

        [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference\"}")]
        public virtual aws.Sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference TensorBoardAppSettings
        {
            get => GetInstanceProperty<aws.Sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettingsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "executionRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ExecutionRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "jupyterServerAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings? JupyterServerAppSettingsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kernelGatewayAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettingsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "securityGroupsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? SecurityGroupsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sharingSettingsInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsSharingSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings? SharingSettingsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tensorBoardAppSettingsInput", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings? TensorBoardAppSettingsInput
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings?>();
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
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettings\"}", isOptional: true)]
        public virtual aws.Sagemaker.ISagemakerDomainDefaultUserSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
