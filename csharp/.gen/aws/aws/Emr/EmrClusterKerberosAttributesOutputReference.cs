using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Emr
{
    [JsiiClass(nativeType: typeof(aws.Emr.EmrClusterKerberosAttributesOutputReference), fullyQualifiedName: "aws.emr.EmrClusterKerberosAttributesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EmrClusterKerberosAttributesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EmrClusterKerberosAttributesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterKerberosAttributesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EmrClusterKerberosAttributesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAdDomainJoinPassword")]
        public virtual void ResetAdDomainJoinPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetAdDomainJoinUser")]
        public virtual void ResetAdDomainJoinUser()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCrossRealmTrustPrincipalPassword")]
        public virtual void ResetCrossRealmTrustPrincipalPassword()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "adDomainJoinPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdDomainJoinPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "adDomainJoinUserInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? AdDomainJoinUserInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "crossRealmTrustPrincipalPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CrossRealmTrustPrincipalPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "kdcAdminPasswordInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? KdcAdminPasswordInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "realmInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? RealmInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "adDomainJoinPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdDomainJoinPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "adDomainJoinUser", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string AdDomainJoinUser
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "crossRealmTrustPrincipalPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string CrossRealmTrustPrincipalPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "kdcAdminPassword", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string KdcAdminPassword
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "realm", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Realm
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.emr.EmrClusterKerberosAttributes\"}", isOptional: true)]
        public virtual aws.Emr.IEmrClusterKerberosAttributes? InternalValue
        {
            get => GetInstanceProperty<aws.Emr.IEmrClusterKerberosAttributes?>();
            set => SetInstanceProperty(value);
        }
    }
}
