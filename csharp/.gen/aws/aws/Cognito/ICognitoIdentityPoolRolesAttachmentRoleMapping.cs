using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiInterface(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentRoleMapping), fullyQualifiedName: "aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMapping")]
    public interface ICognitoIdentityPoolRolesAttachmentRoleMapping
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#identity_provider CognitoIdentityPoolRolesAttachment#identity_provider}.</summary>
        [JsiiProperty(name: "identityProvider", typeJson: "{\"primitive\":\"string\"}")]
        string IdentityProvider
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#type CognitoIdentityPoolRolesAttachment#type}.</summary>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#ambiguous_role_resolution CognitoIdentityPoolRolesAttachment#ambiguous_role_resolution}.</summary>
        [JsiiProperty(name: "ambiguousRoleResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? AmbiguousRoleResolution
        {
            get
            {
                return null;
            }
        }

        /// <summary>mapping_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#mapping_rule CognitoIdentityPoolRolesAttachment#mapping_rule}
        /// </remarks>
        [JsiiProperty(name: "mappingRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule[]? MappingRule
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICognitoIdentityPoolRolesAttachmentRoleMapping), fullyQualifiedName: "aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMapping")]
        internal sealed class _Proxy : DeputyBase, aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMapping
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#identity_provider CognitoIdentityPoolRolesAttachment#identity_provider}.</summary>
            [JsiiProperty(name: "identityProvider", typeJson: "{\"primitive\":\"string\"}")]
            public string IdentityProvider
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#type CognitoIdentityPoolRolesAttachment#type}.</summary>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#ambiguous_role_resolution CognitoIdentityPoolRolesAttachment#ambiguous_role_resolution}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ambiguousRoleResolution", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? AmbiguousRoleResolution
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>mapping_rule block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cognito_identity_pool_roles_attachment#mapping_rule CognitoIdentityPoolRolesAttachment#mapping_rule}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mappingRule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.cognito.CognitoIdentityPoolRolesAttachmentRoleMappingMappingRule\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule[]? MappingRule
            {
                get => GetInstanceProperty<aws.Cognito.ICognitoIdentityPoolRolesAttachmentRoleMappingMappingRule[]?>();
            }
        }
    }
}
