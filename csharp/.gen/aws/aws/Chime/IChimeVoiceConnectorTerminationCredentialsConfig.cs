using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Chime
{
    /// <summary>Amazon Chime.</summary>
    [JsiiInterface(nativeType: typeof(IChimeVoiceConnectorTerminationCredentialsConfig), fullyQualifiedName: "aws.chime.ChimeVoiceConnectorTerminationCredentialsConfig")]
    public interface IChimeVoiceConnectorTerminationCredentialsConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>credentials block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/chime_voice_connector_termination_credentials#credentials ChimeVoiceConnectorTerminationCredentials#credentials}
        /// </remarks>
        [JsiiProperty(name: "credentials", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.chime.ChimeVoiceConnectorTerminationCredentialsCredentials\"},\"kind\":\"array\"}}")]
        aws.Chime.IChimeVoiceConnectorTerminationCredentialsCredentials[] Credentials
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/chime_voice_connector_termination_credentials#voice_connector_id ChimeVoiceConnectorTerminationCredentials#voice_connector_id}.</summary>
        [JsiiProperty(name: "voiceConnectorId", typeJson: "{\"primitive\":\"string\"}")]
        string VoiceConnectorId
        {
            get;
        }

        /// <summary>Amazon Chime.</summary>
        [JsiiTypeProxy(nativeType: typeof(IChimeVoiceConnectorTerminationCredentialsConfig), fullyQualifiedName: "aws.chime.ChimeVoiceConnectorTerminationCredentialsConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Chime.IChimeVoiceConnectorTerminationCredentialsConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>credentials block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/chime_voice_connector_termination_credentials#credentials ChimeVoiceConnectorTerminationCredentials#credentials}
            /// </remarks>
            [JsiiProperty(name: "credentials", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.chime.ChimeVoiceConnectorTerminationCredentialsCredentials\"},\"kind\":\"array\"}}")]
            public aws.Chime.IChimeVoiceConnectorTerminationCredentialsCredentials[] Credentials
            {
                get => GetInstanceProperty<aws.Chime.IChimeVoiceConnectorTerminationCredentialsCredentials[]>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/chime_voice_connector_termination_credentials#voice_connector_id ChimeVoiceConnectorTerminationCredentials#voice_connector_id}.</summary>
            [JsiiProperty(name: "voiceConnectorId", typeJson: "{\"primitive\":\"string\"}")]
            public string VoiceConnectorId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"number\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Count
            {
                get => GetInstanceProperty<object?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dependsOn", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"cdktf.ITerraformDependable\"},\"kind\":\"array\"}}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformDependable[]? DependsOn
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformDependable[]?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "lifecycle", typeJson: "{\"fqn\":\"cdktf.TerraformResourceLifecycle\"}", isOptional: true)]
            public HashiCorp.Cdktf.ITerraformResourceLifecycle? Lifecycle
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.ITerraformResourceLifecycle?>();
            }

            /// <remarks>
            /// <strong>Stability</strong>: Experimental
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "provider", typeJson: "{\"fqn\":\"cdktf.TerraformProvider\"}", isOptional: true)]
            public HashiCorp.Cdktf.TerraformProvider? Provider
            {
                get => GetInstanceProperty<HashiCorp.Cdktf.TerraformProvider?>();
            }
        }
    }
}
