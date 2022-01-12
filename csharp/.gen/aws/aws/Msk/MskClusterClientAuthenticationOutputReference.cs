using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiClass(nativeType: typeof(aws.Msk.MskClusterClientAuthenticationOutputReference), fullyQualifiedName: "aws.msk.MskClusterClientAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class MskClusterClientAuthenticationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public MskClusterClientAuthenticationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterClientAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected MskClusterClientAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSasl", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterClientAuthenticationSasl\"}}]")]
        public virtual void PutSasl(aws.Msk.IMskClusterClientAuthenticationSasl @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterClientAuthenticationSasl)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTls", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.msk.MskClusterClientAuthenticationTls\"}}]")]
        public virtual void PutTls(aws.Msk.IMskClusterClientAuthenticationTls @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Msk.IMskClusterClientAuthenticationTls)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSasl")]
        public virtual void ResetSasl()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetTls")]
        public virtual void ResetTls()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "sasl", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationSaslOutputReference\"}")]
        public virtual aws.Msk.MskClusterClientAuthenticationSaslOutputReference Sasl
        {
            get => GetInstanceProperty<aws.Msk.MskClusterClientAuthenticationSaslOutputReference>()!;
        }

        [JsiiProperty(name: "tls", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationTlsOutputReference\"}")]
        public virtual aws.Msk.MskClusterClientAuthenticationTlsOutputReference Tls
        {
            get => GetInstanceProperty<aws.Msk.MskClusterClientAuthenticationTlsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "saslInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationSasl\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterClientAuthenticationSasl? SaslInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterClientAuthenticationSasl?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "tlsInput", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthenticationTls\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterClientAuthenticationTls? TlsInput
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterClientAuthenticationTls?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.msk.MskClusterClientAuthentication\"}", isOptional: true)]
        public virtual aws.Msk.IMskClusterClientAuthentication? InternalValue
        {
            get => GetInstanceProperty<aws.Msk.IMskClusterClientAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
