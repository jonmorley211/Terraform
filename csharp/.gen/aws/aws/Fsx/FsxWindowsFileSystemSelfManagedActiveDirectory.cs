using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.fsx.FsxWindowsFileSystemSelfManagedActiveDirectory")]
    public class FsxWindowsFileSystemSelfManagedActiveDirectory : aws.Fsx.IFsxWindowsFileSystemSelfManagedActiveDirectory
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#dns_ips FsxWindowsFileSystem#dns_ips}.</summary>
        [JsiiProperty(name: "dnsIps", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOverride: true)]
        public string[] DnsIps
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#domain_name FsxWindowsFileSystem#domain_name}.</summary>
        [JsiiProperty(name: "domainName", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string DomainName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#password FsxWindowsFileSystem#password}.</summary>
        [JsiiProperty(name: "password", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Password
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#username FsxWindowsFileSystem#username}.</summary>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Username
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#file_system_administrators_group FsxWindowsFileSystem#file_system_administrators_group}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "fileSystemAdministratorsGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? FileSystemAdministratorsGroup
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_windows_file_system#organizational_unit_distinguished_name FsxWindowsFileSystem#organizational_unit_distinguished_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "organizationalUnitDistinguishedName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OrganizationalUnitDistinguishedName
        {
            get;
            set;
        }
    }
}
