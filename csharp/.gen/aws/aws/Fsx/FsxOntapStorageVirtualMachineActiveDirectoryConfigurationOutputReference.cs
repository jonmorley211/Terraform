using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationOutputReference), fullyQualifiedName: "aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FsxOntapStorageVirtualMachineActiveDirectoryConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public FsxOntapStorageVirtualMachineActiveDirectoryConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapStorageVirtualMachineActiveDirectoryConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxOntapStorageVirtualMachineActiveDirectoryConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSelfManagedActiveDirectoryConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration\"}}]")]
        public virtual void PutSelfManagedActiveDirectoryConfiguration(aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetNetbiosName")]
        public virtual void ResetNetbiosName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSelfManagedActiveDirectoryConfiguration")]
        public virtual void ResetSelfManagedActiveDirectoryConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "selfManagedActiveDirectoryConfiguration", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfigurationOutputReference\"}")]
        public virtual aws.Fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfigurationOutputReference SelfManagedActiveDirectoryConfiguration
        {
            get => GetInstanceProperty<aws.Fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfigurationOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "netbiosNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NetbiosNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "selfManagedActiveDirectoryConfigurationInput", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration? SelfManagedActiveDirectoryConfigurationInput
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfigurationSelfManagedActiveDirectoryConfiguration?>();
        }

        [JsiiProperty(name: "netbiosName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string NetbiosName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsx.FsxOntapStorageVirtualMachineActiveDirectoryConfiguration\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Fsx.IFsxOntapStorageVirtualMachineActiveDirectoryConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
