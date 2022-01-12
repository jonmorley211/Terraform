using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualGatewaySpecListenerTlsValidationTrustOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualGatewaySpecListenerTlsValidationTrustOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerTlsValidationTrustOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecListenerTlsValidationTrustOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustFile\"}}]")]
        public virtual void PutFile(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrustFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrustFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSds", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustSds\"}}]")]
        public virtual void PutSds(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrustSds @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrustSds)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFile")]
        public virtual void ResetFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSds")]
        public virtual void ResetSds()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustFileOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustFileOutputReference File
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustFileOutputReference>()!;
        }

        [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustSdsOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustSdsOutputReference Sds
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustSdsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustFile\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrustFile? FileInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrustFile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sdsInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrustSds\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrustSds? SdsInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrustSds?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecListenerTlsValidationTrust\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrust? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecListenerTlsValidationTrust?>();
            set => SetInstanceProperty(value);
        }
    }
}
