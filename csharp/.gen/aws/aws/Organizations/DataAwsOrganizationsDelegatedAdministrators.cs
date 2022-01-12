using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Organizations
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/d/organizations_delegated_administrators aws_organizations_delegated_administrators}.</summary>
    [JsiiClass(nativeType: typeof(aws.Organizations.DataAwsOrganizationsDelegatedAdministrators), fullyQualifiedName: "aws.organizations.DataAwsOrganizationsDelegatedAdministrators", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"optional\":true,\"type\":{\"fqn\":\"aws.organizations.DataAwsOrganizationsDelegatedAdministratorsConfig\"}}]")]
    public class DataAwsOrganizationsDelegatedAdministrators : HashiCorp.Cdktf.TerraformDataSource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/d/organizations_delegated_administrators aws_organizations_delegated_administrators} Data Source.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public DataAwsOrganizationsDelegatedAdministrators(Constructs.Construct scope, string id, aws.Organizations.IDataAwsOrganizationsDelegatedAdministratorsConfig? config = null): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsDelegatedAdministrators(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataAwsOrganizationsDelegatedAdministrators(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "delegatedAdministrators", returnsJson: "{\"type\":{\"fqn\":\"aws.organizations.DataAwsOrganizationsDelegatedAdministratorsDelegatedAdministrators\"}}", parametersJson: "[{\"name\":\"index\",\"type\":{\"primitive\":\"string\"}}]")]
        public virtual aws.Organizations.DataAwsOrganizationsDelegatedAdministratorsDelegatedAdministrators DelegatedAdministrators(string index)
        {
            return InvokeInstanceMethod<aws.Organizations.DataAwsOrganizationsDelegatedAdministratorsDelegatedAdministrators>(new System.Type[]{typeof(string)}, new object[]{index})!;
        }

        [JsiiMethod(name: "resetServicePrincipal")]
        public virtual void ResetServicePrincipal()
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
        = GetStaticProperty<string>(typeof(aws.Organizations.DataAwsOrganizationsDelegatedAdministrators))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "servicePrincipalInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServicePrincipalInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "servicePrincipal", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServicePrincipal
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }
    }
}
