using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Datasync
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_hdfs aws_datasync_location_hdfs}.</summary>
    [JsiiClass(nativeType: typeof(aws.Datasync.DatasyncLocationHdfs), fullyQualifiedName: "aws.datasync.DatasyncLocationHdfs", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.datasync.DatasyncLocationHdfsConfig\"}}]")]
    public class DatasyncLocationHdfs : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/datasync_location_hdfs aws_datasync_location_hdfs} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DatasyncLocationHdfs(Constructs.Construct scope, string id, aws.Datasync.IDatasyncLocationHdfsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationHdfs(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DatasyncLocationHdfs(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putQopConfiguration", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.datasync.DatasyncLocationHdfsQopConfiguration\"}}]")]
        public virtual void PutQopConfiguration(aws.Datasync.IDatasyncLocationHdfsQopConfiguration @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Datasync.IDatasyncLocationHdfsQopConfiguration)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAuthenticationType")]
        public virtual void ResetAuthenticationType()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBlockSize")]
        public virtual void ResetBlockSize()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKerberosKeytab")]
        public virtual void ResetKerberosKeytab()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKerberosKrb5Conf")]
        public virtual void ResetKerberosKrb5Conf()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKerberosPrincipal")]
        public virtual void ResetKerberosPrincipal()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetKmsKeyProviderUri")]
        public virtual void ResetKmsKeyProviderUri()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetQopConfiguration")]
        public virtual void ResetQopConfiguration()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetReplicationFactor")]
        public virtual void ResetReplicationFactor()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSimpleUser")]
        public virtual void ResetSimpleUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubdirectory")]
        public virtual void ResetSubdirectory()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTagsAll")]
        public virtual void ResetTagsAll()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Datasync.DatasyncLocationHdfs))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "qopConfiguration", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationHdfsQopConfigurationOutputReference\"}")]
        public virtual aws.Datasync.DatasyncLocationHdfsQopConfigurationOutputReference QopConfiguration
        {
            get => GetInstanceProperty<aws.Datasync.DatasyncLocationHdfsQopConfigurationOutputReference>()!;
        }

        [JsiiProperty(name: "uri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Uri
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "agentArnsInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AgentArnsInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "authenticationTypeInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AuthenticationTypeInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "blockSizeInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? BlockSizeInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kerberosKeytabInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KerberosKeytabInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kerberosKrb5ConfInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KerberosKrb5ConfInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kerberosPrincipalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KerberosPrincipalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kmsKeyProviderUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KmsKeyProviderUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameNodeInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datasync.DatasyncLocationHdfsNameNode\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Datasync.IDatasyncLocationHdfsNameNode[]? NameNodeInput
        {
            get => GetInstanceProperty<aws.Datasync.IDatasyncLocationHdfsNameNode[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "qopConfigurationInput", typeJson: "{\"fqn\":\"aws.datasync.DatasyncLocationHdfsQopConfiguration\"}", isOptional: true)]
        public virtual aws.Datasync.IDatasyncLocationHdfsQopConfiguration? QopConfigurationInput
        {
            get => GetInstanceProperty<aws.Datasync.IDatasyncLocationHdfsQopConfiguration?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "replicationFactorInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ReplicationFactorInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "simpleUserInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SimpleUserInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subdirectoryInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubdirectoryInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsAllInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsAllInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "agentArns", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AgentArns
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationType
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "blockSize", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double BlockSize
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kerberosKeytab", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KerberosKeytab
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kerberosKrb5Conf", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KerberosKrb5Conf
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kerberosPrincipal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KerberosPrincipal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kmsKeyProviderUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KmsKeyProviderUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "nameNode", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.datasync.DatasyncLocationHdfsNameNode\"},\"kind\":\"array\"}}")]
        public virtual aws.Datasync.IDatasyncLocationHdfsNameNode[] NameNode
        {
            get => GetInstanceProperty<aws.Datasync.IDatasyncLocationHdfsNameNode[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "replicationFactor", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ReplicationFactor
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "simpleUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SimpleUser
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subdirectory", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Subdirectory
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

        [JsiiProperty(name: "tagsAll", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object TagsAll
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
