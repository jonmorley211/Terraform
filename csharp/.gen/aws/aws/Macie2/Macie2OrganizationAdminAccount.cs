using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Macie2
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/macie2_organization_admin_account aws_macie2_organization_admin_account}.</summary>
    [JsiiClass(nativeType: typeof(aws.Macie2.Macie2OrganizationAdminAccount), fullyQualifiedName: "aws.macie2.Macie2OrganizationAdminAccount", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.macie2.Macie2OrganizationAdminAccountConfig\"}}]")]
    public class Macie2OrganizationAdminAccount : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/macie2_organization_admin_account aws_macie2_organization_admin_account} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public Macie2OrganizationAdminAccount(Constructs.Construct scope, string id, aws.Macie2.IMacie2OrganizationAdminAccountConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2OrganizationAdminAccount(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Macie2OrganizationAdminAccount(DeputyProps props): base(props)
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
        = GetStaticProperty<string>(typeof(aws.Macie2.Macie2OrganizationAdminAccount))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "adminAccountIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdminAccountIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adminAccountId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdminAccountId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
