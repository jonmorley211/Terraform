using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Workspaces
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/workspaces_directory aws_workspaces_directory}.</summary>
    [JsiiClass(nativeType: typeof(aws.Workspaces.DataAwsWorkspacesDirectory), fullyQualifiedName: "aws.workspaces.DataAwsWorkspacesDirectory", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.workspaces.DataAwsWorkspacesDirectoryConfig\"}}]")]
    public class DataAwsWorkspacesDirectory : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/workspaces_directory aws_workspaces_directory} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsWorkspacesDirectory(Constructs.Construct scope, string id, aws.Workspaces.IDataAwsWorkspacesDirectoryConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectory(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsWorkspacesDirectory(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "selfServicePermissions", returnsJson: "{\"type\":{\"fqn\":\"aws.workspaces.DataAwsWorkspacesDirectorySelfServicePermissions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Workspaces.DataAwsWorkspacesDirectorySelfServicePermissions SelfServicePermissions(string index)
        {
            return InvokeInstanceMethod<aws.Workspaces.DataAwsWorkspacesDirectorySelfServicePermissions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "workspaceAccessProperties", returnsJson: "{\"type\":{\"fqn\":\"aws.workspaces.DataAwsWorkspacesDirectoryWorkspaceAccessProperties\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Workspaces.DataAwsWorkspacesDirectoryWorkspaceAccessProperties WorkspaceAccessProperties(string index)
        {
            return InvokeInstanceMethod<aws.Workspaces.DataAwsWorkspacesDirectoryWorkspaceAccessProperties>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "workspaceCreationProperties", returnsJson: "{\"type\":{\"fqn\":\"aws.workspaces.DataAwsWorkspacesDirectoryWorkspaceCreationProperties\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Workspaces.DataAwsWorkspacesDirectoryWorkspaceCreationProperties WorkspaceCreationProperties(string index)
        {
            return InvokeInstanceMethod<aws.Workspaces.DataAwsWorkspacesDirectoryWorkspaceCreationProperties>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Workspaces.DataAwsWorkspacesDirectory))!;

        [JsiiProperty(name: "alias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Alias
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "customerUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CustomerUserName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryName
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "directoryType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "dnsIpAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] DnsIpAddresses
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "iamRoleId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IamRoleId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "ipGroupIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] IpGroupIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "registrationCode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RegistrationCode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "workspaceSecurityGroupId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string WorkspaceSecurityGroupId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "directoryIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DirectoryIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "directoryId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DirectoryId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "tags", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Tags
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
