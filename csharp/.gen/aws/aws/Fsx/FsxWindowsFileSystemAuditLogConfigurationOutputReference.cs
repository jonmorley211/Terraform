using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Fsx
{
    [JsiiClass(nativeType: typeof(aws.Fsx.FsxWindowsFileSystemAuditLogConfigurationOutputReference), fullyQualifiedName: "aws.fsx.FsxWindowsFileSystemAuditLogConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class FsxWindowsFileSystemAuditLogConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public FsxWindowsFileSystemAuditLogConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxWindowsFileSystemAuditLogConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected FsxWindowsFileSystemAuditLogConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuditLogDestination")]
        public virtual void ResetAuditLogDestination()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileAccessAuditLogLevel")]
        public virtual void ResetFileAccessAuditLogLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetFileShareAccessAuditLogLevel")]
        public virtual void ResetFileShareAccessAuditLogLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "auditLogDestinationInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuditLogDestinationInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileAccessAuditLogLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileAccessAuditLogLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileShareAccessAuditLogLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? FileShareAccessAuditLogLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "auditLogDestination", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuditLogDestination
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileAccessAuditLogLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "fileShareAccessAuditLogLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string FileShareAccessAuditLogLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.fsx.FsxWindowsFileSystemAuditLogConfiguration\"}", isOptional: true)]
        public virtual aws.Fsx.IFsxWindowsFileSystemAuditLogConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Fsx.IFsxWindowsFileSystemAuditLogConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
