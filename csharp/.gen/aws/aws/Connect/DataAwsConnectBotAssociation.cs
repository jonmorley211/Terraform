using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Connect
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/connect_bot_association aws_connect_bot_association}.</summary>
    [JsiiClass(nativeType: typeof(aws.Connect.DataAwsConnectBotAssociation), fullyQualifiedName: "aws.connect.DataAwsConnectBotAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.connect.DataAwsConnectBotAssociationConfig\"}}]")]
    public class DataAwsConnectBotAssociation : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/connect_bot_association aws_connect_bot_association} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsConnectBotAssociation(Constructs.Construct scope, string id, aws.Connect.IDataAwsConnectBotAssociationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsConnectBotAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsConnectBotAssociation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLexBot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connect.DataAwsConnectBotAssociationLexBot\"}}]")]
        public virtual void PutLexBot(aws.Connect.IDataAwsConnectBotAssociationLexBot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Connect.IDataAwsConnectBotAssociationLexBot)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Connect.DataAwsConnectBotAssociation))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lexBot", typeJson: "{\"fqn\":\"aws.connect.DataAwsConnectBotAssociationLexBotOutputReference\"}")]
        public virtual aws.Connect.DataAwsConnectBotAssociationLexBotOutputReference LexBot
        {
            get => GetInstanceProperty<aws.Connect.DataAwsConnectBotAssociationLexBotOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lexBotInput", typeJson: "{\"fqn\":\"aws.connect.DataAwsConnectBotAssociationLexBot\"}", isOptional: true)]
        public virtual aws.Connect.IDataAwsConnectBotAssociationLexBot? LexBotInput
        {
            get => GetInstanceProperty<aws.Connect.IDataAwsConnectBotAssociationLexBot?>();
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
