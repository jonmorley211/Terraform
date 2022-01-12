using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiInterface(nativeType: typeof(IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration), fullyQualifiedName: "aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration")]
    public interface IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_storage_virtual_machine#netbios_name FsxOntapStorageVirtualMachine#netbios_name}.</summary>
        [JsiiProperty(name: "netbiosName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NetbiosName
        {
            get
            {
                return null;
            }
        }

        /// <summary>self_managed_active_directory_configuration block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_storage_virtual_machine#self_managed_active_directory_configuration FsxOntapStorageVirtualMachine#self_managed_active_directory_configuration}
        /// </remarks>
        [JsiiProperty(name: "selfManagedActiveDirectoryConfiguration", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration? SelfManagedActiveDirectoryConfiguration
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration), fullyQualifiedName: "aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration")]
        internal sealed class _Proxy : DeputyBase, aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_storage_virtual_machine#netbios_name FsxOntapStorageVirtualMachine#netbios_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "netbiosName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NetbiosName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>self_managed_active_directory_configuration block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/fsx_ontap_storage_virtual_machine#self_managed_active_directory_configuration FsxOntapStorageVirtualMachine#self_managed_active_directory_configuration}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfManagedActiveDirectoryConfiguration", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration\"}", isOptional: true)]
            public aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration? SelfManagedActiveDirectoryConfiguration
            {
                get => GetInstanceProperty<aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration?>();
            }
        }
    }
}
