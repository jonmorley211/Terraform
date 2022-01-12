using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Lex
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.lex.LexBotAliasConversationLogs")]
    public class LexBotAliasConversationLogs : aws.Lex.ILexBotAliasConversationLogs
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot_alias#iam_role_arn LexBotAlias#iam_role_arn}.</summary>
        [JsiiProperty(name: "iamRoleArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string IamRoleArn
        {
            get;
            set;
        }

        /// <summary>log_settings block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lex_bot_alias#log_settings LexBotAlias#log_settings}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "logSettings", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.lex.LexBotAliasConversationLogsLogSettings\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public aws.Lex.ILexBotAliasConversationLogsLogSettings[]? LogSettings
        {
            get;
            set;
        }
    }
}
