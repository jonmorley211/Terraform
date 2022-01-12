using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecListenerTlsValidationTrustOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecListenerTlsValidationTrustOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTlsValidationTrustOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTlsValidationTrustOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustFile\"}}]")]
        public virtual void PutFile(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSds", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustSds\"}}]")]
        public virtual void PutSds(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustSds @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustSds)}, new object[]{@value});
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

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustFileOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustFileOutputReference File
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustFileOutputReference>()!;
        }

        [JsiiProperty(name: "sds", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustSdsOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustSdsOutputReference Sds
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustSdsOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustFile\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustFile? FileInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustFile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sdsInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrustSds\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustSds? SdsInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrustSds?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTlsValidationTrust\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrust? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTlsValidationTrust?>();
            set => SetInstanceProperty(value);
        }
    }
}
