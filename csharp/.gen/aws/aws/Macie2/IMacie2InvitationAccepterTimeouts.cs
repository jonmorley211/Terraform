using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    [JsiiInterface(nativeType: typeof(IMacie2InvitationAccepterTimeouts), fullyQualifiedName: "aws.macie2.Macie2InvitationAccepterTimeouts")]
    public interface IMacie2InvitationAccepterTimeouts
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_invitation_accepter#create Macie2InvitationAccepter#create}.</summary>
        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Create
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMacie2InvitationAccepterTimeouts), fullyQualifiedName: "aws.macie2.Macie2InvitationAccepterTimeouts")]
        internal sealed class _Proxy : DeputyBase, aws.Macie2.IMacie2InvitationAccepterTimeouts
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/macie2_invitation_accepter#create Macie2InvitationAccepter#create}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Create
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
