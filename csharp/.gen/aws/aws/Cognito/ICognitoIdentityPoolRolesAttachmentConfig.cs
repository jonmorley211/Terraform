using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    /// <summary>AWS Cognito.</summary>
    [JsiiInterface(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentConfig), fullyQualifiedName: "aws.cognito.CognitoIdentityPoolRolesAttachmentConfig")]
    public interface ICognitoIdentityPoolRolesAttachmentConfig : HashiCorp.Cdktf.ITerraformMetaArguments
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#identity_pool_id CognitoIdentityPoolRolesAttachment#identity_pool_id}.</summary>
        [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityPoolId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#roles CognitoIdentityPoolRolesAttachment#roles}.</summary>
        [JsiiProperty(name: "roles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
        object Roles
        {
            get;
        }

        /// <summary>role_mapping block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#role_mapping CognitoIdentityPoolRolesAttachment#role_mapping}
        /// </remarks>
        [JsiiProperty(name: "roleMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMapping\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMapping[]? RoleMapping
        {
            get
            {
                return null;
            }
        }

        /// <summary>AWS Cognito.</summary>
        [JsiiTypeProxy(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentConfig), fullyQualifiedName: "aws.cognito.CognitoIdentityPoolRolesAttachmentConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoIdentityPoolRolesAttachmentConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#identity_pool_id CognitoIdentityPoolRolesAttachment#identity_pool_id}.</summary>
            [JsiiProperty(name: "identityPoolId", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityPoolId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#roles CognitoIdentityPoolRolesAttachment#roles}.</summary>
            [JsiiProperty(name: "roles", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}")]
            public object Roles
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>role_mapping block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#role_mapping CognitoIdentityPoolRolesAttachment#role_mapping}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "roleMapping", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMapping\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMapping[]? RoleMapping
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMapping[]?>();
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
