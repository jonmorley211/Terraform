using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    [JsiiByValue(fqn: "aws.workspaces.WorkspacesDirectoryWorkspaceCreationProperties")]
    public class WorkspacesDirectoryWorkspaceCreationProperties : aws.Workspaces.IWorkspacesDirectoryWorkspaceCreationProperties
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#custom_security_group_id WorkspacesDirectory#custom_security_group_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "customSecurityGroupId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CustomSecurityGroupId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#default_ou WorkspacesDirectory#default_ou}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "defaultOu", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? DefaultOu
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#enable_internet_access WorkspacesDirectory#enable_internet_access}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableInternetAccess", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnableInternetAccess
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#enable_maintenance_mode WorkspacesDirectory#enable_maintenance_mode}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "enableMaintenanceMode", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? EnableMaintenanceMode
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/workspaces_directory#user_enabled_as_local_administrator WorkspacesDirectory#user_enabled_as_local_administrator}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "userEnabledAsLocalAdministrator", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? UserEnabledAsLocalAdministrator
        {
            get;
            set;
        }
    }
}
