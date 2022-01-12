using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerUserProfileUserSettings")]
    public class SagemakerUserProfileUserSettings : aws.Sagemaker.ISagemakerUserProfileUserSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#execution_role SagemakerUserProfile#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ExecutionRole
        {
            get;
            set;
        }

        /// <summary>jupyter_server_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#jupyter_server_app_settings SagemakerUserProfile#jupyter_server_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsJupyterServerAppSettings\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerUserProfileUserSettingsJupyterServerAppSettings? JupyterServerAppSettings
        {
            get;
            set;
        }

        /// <summary>kernel_gateway_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#kernel_gateway_app_settings SagemakerUserProfile#kernel_gateway_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsKernelGatewayAppSettings\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerUserProfileUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#security_groups SagemakerUserProfile#security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        /// <summary>sharing_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#sharing_settings SagemakerUserProfile#sharing_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsSharingSettings\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerUserProfileUserSettingsSharingSettings? SharingSettings
        {
            get;
            set;
        }

        /// <summary>tensor_board_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_user_profile#tensor_board_app_settings SagemakerUserProfile#tensor_board_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerUserProfileUserSettingsTensorBoardAppSettings\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerUserProfileUserSettingsTensorBoardAppSettings? TensorBoardAppSettings
        {
            get;
            set;
        }
    }
}
