using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Connect
{
    [JsiiInterface(nativeType: typeof(IConnectBotAssociationLexBot), fullyQualifiedName: "aws.connect.ConnectBotAssociationLexBot")]
    public interface IConnectBotAssociationLexBot
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_bot_association#name ConnectBotAssociation#name}.</summary>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_bot_association#lex_region ConnectBotAssociation#lex_region}.</summary>
        [JsiiProperty(name: "lexRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LexRegion
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IConnectBotAssociationLexBot), fullyQualifiedName: "aws.connect.ConnectBotAssociationLexBot")]
        internal sealed class _Proxy : DeputyBase, aws.Connect.IConnectBotAssociationLexBot
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_bot_association#name ConnectBotAssociation#name}.</summary>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/connect_bot_association#lex_region ConnectBotAssociation#lex_region}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "lexRegion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LexRegion
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
