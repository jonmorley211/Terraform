using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualRouterSpecOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualRouterSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualRouterSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualRouterSpecOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualRouterSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualRouterSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putListener", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListener\"}}]")]
        public virtual void PutListener(aws.Appmesh.IAppmeshVirtualRouterSpecListener @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualRouterSpecListener)}, new object[]{@value});
        }

        [JsiiProperty(name: "listener", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListenerOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualRouterSpecListenerOutputReference Listener
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualRouterSpecListenerOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "listenerInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpecListener\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualRouterSpecListener? ListenerInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualRouterSpecListener?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualRouterSpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualRouterSpec? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualRouterSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
