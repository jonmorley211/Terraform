using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiByValue(fqn: "aws.fsx.FsxWindowsFileSystemAuditLogConfiguration")]
    public class FsxWindowsFileSystemAuditLogConfiguration : aws.Fsx.IFsxWindowsFileSystemAuditLogConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#audit_log_destination FsxWindowsFileSystem#audit_log_destination}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "auditLogDestination", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? AuditLogDestination
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#file_access_audit_log_level FsxWindowsFileSystem#file_access_audit_log_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FileAccessAuditLogLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#file_share_access_audit_log_level FsxWindowsFileSystem#file_share_access_audit_log_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileShareAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FileShareAccessAuditLogLevel
        {
            get;
            set;
        }
    }
}
