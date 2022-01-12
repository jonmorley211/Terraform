using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Chime
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/chime_voice_connector_termination_credentials aws_chime_voice_connector_termination_credentials}.</summary>
    [JsiiClass(nativeType: typeof(aws.Chime.ChimeVoiceConnectorTerminationCredentials), fullyQualifiedName: "aws.chime.ChimeVoiceConnectorTerminationCredentials", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.chime.ChimeVoiceConnectorTerminationCredentialsConfig\"}}]")]
    public class ChimeVoiceConnectorTerminationCredentials : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/chime_voice_connector_termination_credentials aws_chime_voice_connector_termination_credentials} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public ChimeVoiceConnectorTerminationCredentials(Constructs.Construct scope, string id, aws.Chime.IChimeVoiceConnectorTerminationCredentialsConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChimeVoiceConnectorTerminationCredentials(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ChimeVoiceConnectorTerminationCredentials(DeputyProps props): base(props)
        {
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
        = GetStaticProperty<string>(typeof(aws.Chime.ChimeVoiceConnectorTerminationCredentials))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "credentialsInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.chime.ChimeVoiceConnectorTerminationCredentialsCredentials\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Chime.IChimeVoiceConnectorTerminationCredentialsCredentials[]? CredentialsInput
        {
            get => GetInstanceProperty<aws.Chime.IChimeVoiceConnectorTerminationCredentialsCredentials[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "voiceConnectorIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VoiceConnectorIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "credentials", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.chime.ChimeVoiceConnectorTerminationCredentialsCredentials\"},\"kind\":\"array\"}}")]
        public virtual aws.Chime.IChimeVoiceConnectorTerminationCredentialsCredentials[] Credentials
        {
            get => GetInstanceProperty<aws.Chime.IChimeVoiceConnectorTerminationCredentialsCredentials[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "voiceConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VoiceConnectorId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
