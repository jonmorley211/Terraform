using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    /// <summary>Represents a {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment aws_cognito_identity_pool_roles_attachment}.</summary>
    [JsiiClass(nativeType: typeof(aws.Cognito.CognitoIdentityPoolRolesAttachment), fullyQualifiedName: "aws.cognito.CognitoIdentityPoolRolesAttachment", parametersJson: "[{\"docs\":{\"summary\":\"The scope in which to define this construct.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"remarks\":\"Must be unique amongst siblings in the same scope\",\"summary\":\"The scoped construct ID.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"name\":\"config\",\"type\":{\"fqn\":\"aws.cognito.CognitoIdentityPoolRolesAttachmentConfig\"}}]")]
    public class CognitoIdentityPoolRolesAttachment : HashiCorp.Cdktf.TerraformResource
    {
        /// <summary>Create a new {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment aws_cognito_identity_pool_roles_attachment} Resource.</summary>
        /// <param name="scope">The scope in which to define this construct.</param>
        /// <param name="id">The scoped construct ID.</param>
        public CognitoIdentityPoolRolesAttachment(Constructs.Construct scope, string id, aws.Cognito.ICognitoIdentityPoolRolesAttachmentConfig config): base(new DeputyProps(new object?[]{scope, id, config}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoIdentityPoolRolesAttachment(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoIdentityPoolRolesAttachment(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetRoleMapping")]
        public virtual void ResetRoleMapping()
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
        = GetStaticProperty<string>(typeof(aws.Cognito.CognitoIdentityPoolRolesAttachment))!;

        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Id
        {
            get => GetInstanceProperty<string>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "identityPoolIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IdentityPoolIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "roleMappingInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMapping\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMapping[]? RoleMappingInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMapping[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rolesInput", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true)]
        public virtual object? RolesInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string IdentityPoolId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roleMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMapping\"},\"kind\":\"array\"}}")]
        public virtual aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMapping[] RoleMapping
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMapping[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "roles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        public virtual object Roles
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }
    }
}
