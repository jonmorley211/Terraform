using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecBackendDefaultsOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecBackendDefaultsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecBackendDefaultsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecBackendDefaultsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecBackendDefaultsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicy\"}}]")]
        public virtual void PutClientPolicy(aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientPolicy")]
        public virtual void ResetClientPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyOutputReference ClientPolicy
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientPolicyInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaultsClientPolicy\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicy? ClientPolicyInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaultsClientPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecBackendDefaults\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecBackendDefaults?>();
            set => SetInstanceProperty(value);
        }
    }
}
