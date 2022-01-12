using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsCertificateSdsOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsCertificateSdsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualGatewaySpecListenerTlsCertificateSdsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualGatewaySpecListenerTlsCertificateSdsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerTlsCertificateSdsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerTlsCertificateSdsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "secretNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SecretNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SecretName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsCertificateSds\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsCertificateSds? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsCertificateSds?>();
            set => SetInstanceProperty(value);
        }
    }
}
