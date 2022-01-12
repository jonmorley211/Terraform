using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Connect
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/connect_instance aws_connect_instance}.</summary>
    [JsiiClass(nativeType: typeof(aws.Connect.DataAwsConnectInstance), fullyQualifiedName: "aws.connect.DataAwsConnectInstance", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.connect.DataAwsConnectInstanceConfig\"}}]")]
    public class DataAwsConnectInstance : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/connect_instance aws_connect_instance} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsConnectInstance(Constructs.Construct scope, string id, aws.Connect.IDataAwsConnectInstanceConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsConnectInstance(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsConnectInstance(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetInstanceAlias")]
        public virtual void ResetInstanceAlias()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInstanceId")]
        public virtual void ResetInstanceId()
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
        = GetStaticProperty<string>(typeof(aws.Connect.DataAwsConnectInstance))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "autoResolveBestVoicesEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object AutoResolveBestVoicesEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "contactFlowLogsEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ContactFlowLogsEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "contactLensEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object ContactLensEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "createdTime", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedTime
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "earlyMediaEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object EarlyMediaEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "identityManagementType", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityManagementType
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "inboundCallsEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object InboundCallsEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "outboundCallsEnabled", typeJson: "{\"primitive\":\"any\"}")]
        public virtual object OutboundCallsEnabled
        {
            get => GetInstanceProperty<object>()!;
        }

        [JsiiProperty(name: "serviceRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServiceRole
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Status
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceAliasInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceAliasInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "instanceAlias", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceAlias
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
