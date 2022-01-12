using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2.Apigatewayv2DomainNameMutualTlsAuthenticationOutputReference), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2DomainNameMutualTlsAuthenticationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Apigatewayv2DomainNameMutualTlsAuthenticationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Apigatewayv2DomainNameMutualTlsAuthenticationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2DomainNameMutualTlsAuthenticationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2DomainNameMutualTlsAuthenticationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetTruststoreVersion")]
        public virtual void ResetTruststoreVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "truststoreUriInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TruststoreUriInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "truststoreVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? TruststoreVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "truststoreUri", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TruststoreUri
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "truststoreVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string TruststoreVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2DomainNameMutualTlsAuthentication\"}", isOptional: true)]
        public virtual aws.Apigatewayv2.IApigatewayv2DomainNameMutualTlsAuthentication? InternalValue
        {
            get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2DomainNameMutualTlsAuthentication?>();
            set => SetInstanceProperty(value);
        }
    }
}
