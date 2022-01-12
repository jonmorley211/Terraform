using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putMatch", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch\"}}]")]
        public virtual void PutMatch(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch)}, new object[]{@value});
        }

        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatchOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatchOutputReference Match
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatchOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "matchInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch? MatchInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNamesMatch?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationSubjectAlternativeNames?>();
            set => SetInstanceProperty(value);
        }
    }
}
