using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cognito
{
    [JsiiClass(nativeType: typeof(aws.Cognito.CognitoUserPoolAdminCreateUserConfigOutputReference), fullyQualifiedName: "aws.cognito.CognitoUserPoolAdminCreateUserConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class CognitoUserPoolAdminCreateUserConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public CognitoUserPoolAdminCreateUserConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolAdminCreateUserConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected CognitoUserPoolAdminCreateUserConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putInviteMessageTemplate", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"}}]")]
        public virtual void PutInviteMessageTemplate(aws.Cognito.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Cognito.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAllowAdminCreateUserOnly")]
        public virtual void ResetAllowAdminCreateUserOnly()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetInviteMessageTemplate")]
        public virtual void ResetInviteMessageTemplate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "inviteMessageTemplate", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference\"}")]
        public virtual aws.Cognito.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference InviteMessageTemplate
        {
            get => GetInstanceProperty<aws.Cognito.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplateOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowAdminCreateUserOnlyInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? AllowAdminCreateUserOnlyInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "inviteMessageTemplateInput", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfigInviteMessageTemplate\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate? InviteMessageTemplateInput
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolAdminCreateUserConfigInviteMessageTemplate?>();
        }

        [JsiiProperty(name: "allowAdminCreateUserOnly", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object AllowAdminCreateUserOnly
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.cognito.CognitoUserPoolAdminCreateUserConfig\"}", isOptional: true)]
        public virtual aws.Cognito.ICognitoUserPoolAdminCreateUserConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Cognito.ICognitoUserPoolAdminCreateUserConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
