using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    [JsiiInterface(nativeType: typeof(ILexBotAliasConversationLogs), fullyQualifiedName: "aws.lex.LexBotAliasConversationLogs")]
    public interface ILexBotAliasConversationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot_alias#iam_role_arn LexBotAlias#iam_role_arn}.</summary>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
        string IamRoleArn
        {
            get;
        }

        /// <summary>log_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot_alias#log_settings LexBotAlias#log_settings}
        /// </remarks>
        [JsiiProperty(name: "logSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotAliasConversationLogsLogSettings\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Lex.ILexBotAliasConversationLogsLogSettings[]? LogSettings
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ILexBotAliasConversationLogs), fullyQualifiedName: "aws.lex.LexBotAliasConversationLogs")]
        internal sealed class _Proxy : DeputyBase, aws.Lex.ILexBotAliasConversationLogs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot_alias#iam_role_arn LexBotAlias#iam_role_arn}.</summary>
            [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}")]
            public string IamRoleArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>log_settings block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot_alias#log_settings LexBotAlias#log_settings}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "logSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotAliasConversationLogsLogSettings\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Lex.ILexBotAliasConversationLogsLogSettings[]? LogSettings
            {
                get => GetInstanceProperty<aws.Lex.ILexBotAliasConversationLogsLogSettings[]?>();
            }
        }
    }
}
