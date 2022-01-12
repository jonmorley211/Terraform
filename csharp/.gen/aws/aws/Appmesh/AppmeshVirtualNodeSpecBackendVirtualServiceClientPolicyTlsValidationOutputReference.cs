using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putSubjectAlternativeNames", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames\"}}]")]
        public virtual void PutSubjectAlternativeNames(aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames)}, new object[]{@value});
        }

        [JsiiMethod(name: "putTrust", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust\"}}]")]
        public virtual void PutTrust(aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetSubjectAlternativeNames")]
        public virtual void ResetSubjectAlternativeNames()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "subjectAlternativeNames", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesOutputReference SubjectAlternativeNames
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNamesOutputReference>()!;
        }

        [JsiiProperty(name: "trust", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustOutputReference Trust
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrustOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "subjectAlternativeNamesInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames? SubjectAlternativeNamesInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationSubjectAlternativeNames?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "trustInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust? TrustInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidationTrust?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidation\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidation? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendVirtualServiceClientPolicyTlsValidation?>();
            set => SetInstanceProperty(value);
        }
    }
}
