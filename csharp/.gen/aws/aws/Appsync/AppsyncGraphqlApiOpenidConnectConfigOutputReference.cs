using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiClass(nativeType: typeof(aws.Appsync.AppsyncGraphqlApiOpenidConnectConfigOutputReference), fullyQualifiedName: "aws.appsync.AppsyncGraphqlApiOpenidConnectConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppsyncGraphqlApiOpenidConnectConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppsyncGraphqlApiOpenidConnectConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiOpenidConnectConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppsyncGraphqlApiOpenidConnectConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAuthTtl")]
        public virtual void ResetAuthTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetClientId")]
        public virtual void ResetClientId()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIatTtl")]
        public virtual void ResetIatTtl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "authTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? AuthTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientIdInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ClientIdInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "iatTtlInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? IatTtlInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "issuerInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? IssuerInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "authTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double AuthTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ClientId
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "iatTtl", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double IatTtl
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Issuer
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiOpenidConnectConfig\"}", isOptional: true)]
        public virtual aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Appsync.IAppsyncGraphqlApiOpenidConnectConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
