using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Connect
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/connect_bot_association aws_connect_bot_association}.</summary>
    [JsiiClass(nativeType: typeof(aws.Connect.ConnectBotAssociation), fullyQualifiedName: "aws.connect.ConnectBotAssociation", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.connect.ConnectBotAssociationConfig\"}}]")]
    public class ConnectBotAssociation : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/connect_bot_association aws_connect_bot_association} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ConnectBotAssociation(Constructs.Construct scope, string id, aws.Connect.IConnectBotAssociationConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectBotAssociation(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ConnectBotAssociation(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putLexBot", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.connect.ConnectBotAssociationLexBot\"}}]")]
        public virtual void PutLexBot(aws.Connect.IConnectBotAssociationLexBot @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Connect.IConnectBotAssociationLexBot)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Connect.ConnectBotAssociation))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lexBot", typeJson: "{\"fqn\":\"aws.connect.ConnectBotAssociationLexBotOutputReference\"}")]
        public virtual aws.Connect.ConnectBotAssociationLexBotOutputReference LexBot
        {
            get => GetInstanceProperty<aws.Connect.ConnectBotAssociationLexBotOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "instanceIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? InstanceIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "lexBotInput", typeJson: "{\"fqn\":\"aws.connect.ConnectBotAssociationLexBot\"}", isOptional: true)]
        public virtual aws.Connect.IConnectBotAssociationLexBot? LexBotInput
        {
            get => GetInstanceProperty<aws.Connect.IConnectBotAssociationLexBot?>();
        }

        [JsiiProperty(name: "instanceId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InstanceId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
