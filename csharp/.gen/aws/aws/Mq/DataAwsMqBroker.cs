using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Mq
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/mq_broker aws_mq_broker}.</summary>
    [JsiiClass(nativeType: typeof(aws.Mq.DataAwsMqBroker), fullyQualifiedName: "aws.mq.DataAwsMqBroker", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerConfig\"}}]")]
    public class DataAwsMqBroker : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/mq_broker aws_mq_broker} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsMqBroker(Constructs.Construct scope, string id, aws.Mq.IDataAwsMqBrokerConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMqBroker(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsMqBroker(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "configuration", returnsJson: "{\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerConfiguration\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Mq.DataAwsMqBrokerConfiguration Configuration(string index)
        {
            return InvokeInstanceMethod<aws.Mq.DataAwsMqBrokerConfiguration>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "encryptionOptions", returnsJson: "{\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerEncryptionOptions\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Mq.DataAwsMqBrokerEncryptionOptions EncryptionOptions(string index)
        {
            return InvokeInstanceMethod<aws.Mq.DataAwsMqBrokerEncryptionOptions>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "instances", returnsJson: "{\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerInstances\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Mq.DataAwsMqBrokerInstances Instances(string index)
        {
            return InvokeInstanceMethod<aws.Mq.DataAwsMqBrokerInstances>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "ldapServerMetadata", returnsJson: "{\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerLdapServerMetadata\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Mq.DataAwsMqBrokerLdapServerMetadata LdapServerMetadata(string index)
        {
            return InvokeInstanceMethod<aws.Mq.DataAwsMqBrokerLdapServerMetadata>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "logs", returnsJson: "{\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerLogs\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Mq.DataAwsMqBrokerLogs Logs(string index)
        {
            return InvokeInstanceMethod<aws.Mq.DataAwsMqBrokerLogs>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "maintenanceWindowStartTime", returnsJson: "{\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerMaintenanceWindowStartTime\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Mq.DataAwsMqBrokerMaintenanceWindowStartTime MaintenanceWindowStartTime(string index)
        {
            return InvokeInstanceMethod<aws.Mq.DataAwsMqBrokerMaintenanceWindowStartTime>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetBrokerId")]
        public virtual void ResetBrokerId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetBrokerName")]
        public virtual void ResetBrokerName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTags")]
        public virtual void ResetTags()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "synthesizeAttributes", returnsJson: "{\"type\":{\"collection\":{\"elementtype\":{\"primitive\":\"any\"},\"kind\":\"map\"}}}", isOverride: true)]
        protected override System.Collections.Generic.IDictionary<string, object> SynthesizeAttributes()
        {
            return InvokeInstanceMethod<System.Collections.Generic.IDictionary<string, object>>(new System.Type[]{}, new object[]{})!;
        }

        [JsiiMethod(name: "user", returnsJson: "{\"type\":{\"fqn\":\"aws.mq.DataAwsMqBrokerUser\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Mq.DataAwsMqBrokerUser User(string index)
        {
            return InvokeInstanceMethod<aws.Mq.DataAwsMqBrokerUser>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiProperty(name: "tfResourceType", typeJson: "{\"primitive\":\"string\"}")]
        public static string TfResourceType
        {
            get;
        }
        = GetStaticProperty<string>(typeof(aws.Mq.DataAwsMqBroker))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "authenticationStrategy", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AuthenticationStrategy
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoMinorVersionUpgrade", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AutoMinorVersionUpgrade
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "deploymentMode", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string DeploymentMode
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "engineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string EngineVersion
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "hostInstanceType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string HostInstanceType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "publiclyAccessible", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object PubliclyAccessible
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "securityGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SecurityGroups
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiProperty(name: "storageType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string StorageType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "subnetIds", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] SubnetIds
        {
            get => GetInstanceProperty<string[]>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrokerIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "brokerNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BrokerNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tagsInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? TagsInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "brokerId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrokerId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "brokerName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BrokerName
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
