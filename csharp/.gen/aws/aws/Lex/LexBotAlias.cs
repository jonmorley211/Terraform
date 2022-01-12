using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/lex_bot_alias aws_lex_bot_alias}.</summary>
    [JsiiClass(nativeType: typeof(aws.Lex.LexBotAlias), fullyQualifiedName: "aws.lex.LexBotAlias", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.lex.LexBotAliasConfig\"}}]")]
    public class LexBotAlias : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/lex_bot_alias aws_lex_bot_alias} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public LexBotAlias(Constructs.Construct scope, string id, aws.Lex.ILexBotAliasConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexBotAlias(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected LexBotAlias(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putConversationLogs", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexBotAliasConversationLogs\"}}]")]
        public virtual void PutConversationLogs(aws.Lex.ILexBotAliasConversationLogs @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexBotAliasConversationLogs)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.lex.LexBotAliasTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Lex.ILexBotAliasTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Lex.ILexBotAliasTimeouts)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetConversationLogs")]
        public virtual void ResetConversationLogs()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDescription")]
        public virtual void ResetDescription()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTimeouts")]
        public virtual void ResetTimeouts()
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
        = GetStaticProperty<string>(typeof(aws.Lex.LexBotAlias))!;

        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Arn
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "checksum", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Checksum
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "conversationLogs", typeJson: "{\"fqn\":\"aws.lex.LexBotAliasConversationLogsOutputReference\"}")]
        public virtual aws.Lex.LexBotAliasConversationLogsOutputReference ConversationLogs
        {
            get => GetInstanceProperty<aws.Lex.LexBotAliasConversationLogsOutputReference>()!;
        }

        [JsiiProperty(name: "createdDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CreatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "lastUpdatedDate", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LastUpdatedDate
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.lex.LexBotAliasTimeoutsOutputReference\"}")]
        public virtual aws.Lex.LexBotAliasTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Lex.LexBotAliasTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "botNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BotNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "botVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? BotVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "conversationLogsInput", typeJson: "{\"fqn\":\"aws.lex.LexBotAliasConversationLogs\"}", isOptional: true)]
        public virtual aws.Lex.ILexBotAliasConversationLogs? ConversationLogsInput
        {
            get => GetInstanceProperty<aws.Lex.ILexBotAliasConversationLogs?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "descriptionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DescriptionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "nameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? NameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.lex.LexBotAliasTimeouts\"}", isOptional: true)]
        public virtual aws.Lex.ILexBotAliasTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Lex.ILexBotAliasTimeouts?>();
        }

        [JsiiProperty(name: "botName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BotName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "botVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string BotVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Description
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Name
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
