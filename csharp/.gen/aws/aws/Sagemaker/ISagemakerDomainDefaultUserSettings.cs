using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerDomainDefaultUserSettings), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettings")]
    public interface ISagemakerDomainDefaultUserSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#execution_role SagemakerDomain#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionRole
        {
            get;
        }

        /// <summary>jupyter_server_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#jupyter_server_app_settings SagemakerDomain#jupyter_server_app_settings}
        /// </remarks>
        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings? JupyterServerAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>kernel_gateway_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#kernel_gateway_app_settings SagemakerDomain#kernel_gateway_app_settings}
        /// </remarks>
        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#security_groups SagemakerDomain#security_groups}.</summary>
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? SecurityGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>sharing_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#sharing_settings SagemakerDomain#sharing_settings}
        /// </remarks>
        [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsSharingSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings? SharingSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>tensor_board_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#tensor_board_app_settings SagemakerDomain#tensor_board_app_settings}
        /// </remarks>
        [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings? TensorBoardAppSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerDomainDefaultUserSettings), fullyQualifiedName: "aws.sagemaker.SagemakerDomainDefaultUserSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerDomainDefaultUserSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#execution_role SagemakerDomain#execution_role}.</summary>
            [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>jupyter_server_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#jupyter_server_app_settings SagemakerDomain#jupyter_server_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings? JupyterServerAppSettings
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings?>();
            }

            /// <summary>kernel_gateway_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#kernel_gateway_app_settings SagemakerDomain#kernel_gateway_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#security_groups SagemakerDomain#security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>sharing_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#sharing_settings SagemakerDomain#sharing_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsSharingSettings\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings? SharingSettings
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings?>();
            }

            /// <summary>tensor_board_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#tensor_board_app_settings SagemakerDomain#tensor_board_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings? TensorBoardAppSettings
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings?>();
            }
        }
    }
}
