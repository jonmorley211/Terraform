using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiByValue(fqn: "aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration")]
    public class FsxOntapStorageVirtualMachineActiveDirectoryConfiguration : aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_storage_virtual_machine#netbios_name FsxOntapStorageVirtualMachine#netbios_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "netbiosName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? NetbiosName
        {
            get;
            set;
        }

        /// <summary>self_managed_active_directory_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_storage_virtual_machine#self_managed_active_directory_configuration FsxOntapStorageVirtualMachine#self_managed_active_directory_configuration}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selfManagedActiveDirectoryConfiguration", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration\"}", isOptional: true, isOverride: true)]
        public aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration? SelfManagedActiveDirectoryConfiguration
        {
            get;
            set;
        }
    }
}
