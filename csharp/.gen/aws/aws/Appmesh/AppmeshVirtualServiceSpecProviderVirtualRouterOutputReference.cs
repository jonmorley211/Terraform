using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualServiceSpecProviderVirtualRouterOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualRouterNameInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? VirtualRouterNameInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "virtualRouterName", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string VirtualRouterName
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualServiceSpecProviderVirtualRouter\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualServiceSpecProviderVirtualRouter?>();
            set => SetInstanceProperty(value);
        }
    }
}
