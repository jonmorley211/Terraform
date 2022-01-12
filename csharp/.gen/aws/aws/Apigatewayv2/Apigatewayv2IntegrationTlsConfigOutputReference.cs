using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2.Apigatewayv2IntegrationTlsConfigOutputReference), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2IntegrationTlsConfigOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Apigatewayv2IntegrationTlsConfigOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Apigatewayv2IntegrationTlsConfigOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2IntegrationTlsConfigOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2IntegrationTlsConfigOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetServerNameToVerify")]
        public virtual void ResetServerNameToVerify()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "serverNameToVerifyInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? ServerNameToVerifyInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "serverNameToVerify", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string ServerNameToVerify
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2IntegrationTlsConfig\"}", isOptional: true)]
        public virtual aws.Apigatewayv2.IApigatewayv2IntegrationTlsConfig? InternalValue
        {
            get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2IntegrationTlsConfig?>();
            set => SetInstanceProperty(value);
        }
    }
}
