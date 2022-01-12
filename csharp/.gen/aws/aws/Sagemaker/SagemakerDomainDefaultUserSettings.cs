using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Sagemaker
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.sagemaker.SagemakerDomainDefaultUserSettings")]
    public class SagemakerDomainDefaultUserSettings : aws.Sagemaker.ISagemakerDomainDefaultUserSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#execution_role SagemakerDomain#execution_role}.</summary>
        [JsiiProperty(name: "executionRole", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ExecutionRole
        {
            get;
            set;
        }

        /// <summary>jupyter_server_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#jupyter_server_app_settings SagemakerDomain#jupyter_server_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "jupyterServerAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsJupyterServerAppSettings\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsJupyterServerAppSettings? JupyterServerAppSettings
        {
            get;
            set;
        }

        /// <summary>kernel_gateway_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#kernel_gateway_app_settings SagemakerDomain#kernel_gateway_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kernelGatewayAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsKernelGatewayAppSettings\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsKernelGatewayAppSettings? KernelGatewayAppSettings
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#security_groups SagemakerDomain#security_groups}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? SecurityGroups
        {
            get;
            set;
        }

        /// <summary>sharing_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#sharing_settings SagemakerDomain#sharing_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sharingSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsSharingSettings\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsSharingSettings? SharingSettings
        {
            get;
            set;
        }

        /// <summary>tensor_board_app_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/sagemaker_domain#tensor_board_app_settings SagemakerDomain#tensor_board_app_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tensorBoardAppSettings", typeJson: "{\"fqn\":\"aws.sagemaker.SagemakerDomainDefaultUserSettingsTensorBoardAppSettings\"}", isOptional: true, isOverride: true)]
        public aws.Sagemaker.ISagemakerDomainDefaultUserSettingsTensorBoardAppSettings? TensorBoardAppSettings
        {
            get;
            set;
        }
    }
}
