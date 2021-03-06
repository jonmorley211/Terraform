using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    [JsiiByValue(fqn: "aws.workspaces.WorkspacesDirectoryWorkspaceAccessProperties")]
    public class WorkspacesDirectoryWorkspaceAccessProperties : aws.Workspaces.IWorkspacesDirectoryWorkspaceAccessProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#device_type_android WorkspacesDirectory#device_type_android}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeAndroid", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceTypeAndroid
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#device_type_chromeos WorkspacesDirectory#device_type_chromeos}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeChromeos", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceTypeChromeos
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#device_type_ios WorkspacesDirectory#device_type_ios}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeIos", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceTypeIos
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#device_type_linux WorkspacesDirectory#device_type_linux}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeLinux", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceTypeLinux
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#device_type_osx WorkspacesDirectory#device_type_osx}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeOsx", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceTypeOsx
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#device_type_web WorkspacesDirectory#device_type_web}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeWeb", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceTypeWeb
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#device_type_windows WorkspacesDirectory#device_type_windows}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeWindows", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceTypeWindows
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#device_type_zeroclient WorkspacesDirectory#device_type_zeroclient}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "deviceTypeZeroclient", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DeviceTypeZeroclient
        {
            get;
            set;
        }
    }
}
