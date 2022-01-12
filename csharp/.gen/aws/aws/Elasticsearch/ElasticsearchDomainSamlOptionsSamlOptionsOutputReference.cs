using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elasticsearch
{
    [JsiiClass(nativeType: typeof(aws.Elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsOutputReference), fullyQualifiedName: "aws.elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class ElasticsearchDomainSamlOptionsSamlOptionsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public ElasticsearchDomainSamlOptionsSamlOptionsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainSamlOptionsSamlOptionsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected ElasticsearchDomainSamlOptionsSamlOptionsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdp", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsIdp\"}}]")]
        public virtual void PutIdp(aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptionsIdp @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptionsIdp)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetEnabled")]
        public virtual void ResetEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIdp")]
        public virtual void ResetIdp()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterBackendRole")]
        public virtual void ResetMasterBackendRole()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetMasterUserName")]
        public virtual void ResetMasterUserName()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRolesKey")]
        public virtual void ResetRolesKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSessionTimeoutMinutes")]
        public virtual void ResetSessionTimeoutMinutes()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSubjectKey")]
        public virtual void ResetSubjectKey()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "idp", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsIdpOutputReference\"}")]
        public virtual aws.Elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsIdpOutputReference Idp
        {
            get => GetInstanceProperty<aws.Elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsIdpOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "enabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? EnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "idpInput", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSamlOptionsSamlOptionsIdp\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptionsIdp? IdpInput
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptionsIdp?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterBackendRoleInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterBackendRoleInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "masterUserNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? MasterUserNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "rolesKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RolesKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeoutMinutesInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? SessionTimeoutMinutesInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectKeyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SubjectKeyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object Enabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterBackendRole", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterBackendRole
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "masterUserName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string MasterUserName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "rolesKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string RolesKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "sessionTimeoutMinutes", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double SessionTimeoutMinutes
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "subjectKey", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SubjectKey
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.elasticsearch.ElasticsearchDomainSamlOptionsSamlOptions\"}", isOptional: true)]
        public virtual aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptions? InternalValue
        {
            get => GetInstanceProperty<aws.Elasticsearch.IElasticsearchDomainSamlOptionsSamlOptions?>();
            set => SetInstanceProperty(value);
        }
    }
}
