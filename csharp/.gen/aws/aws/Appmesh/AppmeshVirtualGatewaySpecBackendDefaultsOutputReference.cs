using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualGatewaySpecBackendDefaultsOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualGatewaySpecBackendDefaultsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualGatewaySpecBackendDefaultsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecBackendDefaultsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecBackendDefaultsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putClientPolicy", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicy\"}}]")]
        public virtual void PutClientPolicy(aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetClientPolicy")]
        public virtual void ResetClientPolicy()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "clientPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyOutputReference ClientPolicy
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicyOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "clientPolicyInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaultsClientPolicy\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy? ClientPolicyInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaultsClientPolicy?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecBackendDefaults\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecBackendDefaults?>();
            set => SetInstanceProperty(value);
        }
    }
}
