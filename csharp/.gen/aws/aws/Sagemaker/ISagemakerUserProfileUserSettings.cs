using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    [JsiiInterface(nativeType: typeof(ISagemakerUserProfileUserSettings), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettings")]
    public interface ISagemakerUserProfileUserSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#execution_role SagemakerUserProfile#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
        string ExecutionRole
        {
            get;
        }

        /// <summary>jupyter_server_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#jupyter_server_app_settings SagemakerUserProfile#jupyter_server_app_settings}
        /// </remarks>
        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings? JupyterServerAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>kernel_gateway_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#kernel_gateway_app_settings SagemakerUserProfile#kernel_gateway_app_settings}
        /// </remarks>
        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#security_groups SagemakerUserProfile#security_groups}.</summary>
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
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#sharing_settings SagemakerUserProfile#sharing_settings}
        /// </remarks>
        [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsSharingSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerUserProfileUserSettingsSharingSettings? SharingSettings
        {
            get
            {
                return null;
            }
        }

        /// <summary>tensor_board_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#tensor_board_app_settings SagemakerUserProfile#tensor_board_app_settings}
        /// </remarks>
        [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings? TensorBoardAppSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ISagemakerUserProfileUserSettings), fullyQualifiedName: "aws.sagemaker.SagemakerUserProfileUserSettings")]
        internal sealed class _Proxy : DeputyBase, aws.Sagemaker.ISagemakerUserProfileUserSettings
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#execution_role SagemakerUserProfile#execution_role}.</summary>
            [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}")]
            public string ExecutionRole
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>jupyter_server_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#jupyter_server_app_settings SagemakerUserProfile#jupyter_server_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettings\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings? JupyterServerAppSettings
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings?>();
            }

            /// <summary>kernel_gateway_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#kernel_gateway_app_settings SagemakerUserProfile#kernel_gateway_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettings\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#security_groups SagemakerUserProfile#security_groups}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? SecurityGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>sharing_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#sharing_settings SagemakerUserProfile#sharing_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsSharingSettings\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerUserProfileUserSettingsSharingSettings? SharingSettings
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsSharingSettings?>();
            }

            /// <summary>tensor_board_app_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#tensor_board_app_settings SagemakerUserProfile#tensor_board_app_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettings\"}", isOptional: true)]
            public aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings? TensorBoardAppSettings
            {
                get => GetInstanceProperty<aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings?>();
            }
        }
    }
}
