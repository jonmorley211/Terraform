using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/macie2_invitation_accepter aws_macie2_invitation_accepter}.</summary>
    [JsiiClass(nativeType: typeof(aws.Macie2.Macie2InvitationAccepter), fullyQualifiedName: "aws.macie2.Macie2InvitationAccepter", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.macie2.Macie2InvitationAccepterConfig\"}}]")]
    public class Macie2InvitationAccepter : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/macie2_invitation_accepter aws_macie2_invitation_accepter} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Macie2InvitationAccepter(Constructs.Construct scope, string id, aws.Macie2.IMacie2InvitationAccepterConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2InvitationAccepter(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2InvitationAccepter(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putTimeouts", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.macie2.Macie2InvitationAccepterTimeouts\"}}]")]
        public virtual void PutTimeouts(aws.Macie2.IMacie2InvitationAccepterTimeouts @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Macie2.IMacie2InvitationAccepterTimeouts)}, new object[]{@value});
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
        = GetStaticProperty<string>(typeof(aws.Macie2.Macie2InvitationAccepter))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "invitationId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string InvitationId
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiProperty(name: "timeouts", typeJson: "{\"fqn\":\"aws.macie2.Macie2InvitationAccepterTimeoutsOutputReference\"}")]
        public virtual aws.Macie2.Macie2InvitationAccepterTimeoutsOutputReference Timeouts
        {
            get => GetInstanceProperty<aws.Macie2.Macie2InvitationAccepterTimeoutsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "administratorAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdministratorAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "timeoutsInput", typeJson: "{\"fqn\":\"aws.macie2.Macie2InvitationAccepterTimeouts\"}", isOptional: true)]
        public virtual aws.Macie2.IMacie2InvitationAccepterTimeouts? TimeoutsInput
        {
            get => GetInstanceProperty<aws.Macie2.IMacie2InvitationAccepterTimeouts?>();
        }

        [JsiiProperty(name: "administratorAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdministratorAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
