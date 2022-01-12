using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecListenerTimeoutHttpOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecListenerTimeoutHttpOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutHttpOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutHttpOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpIdle\"}}]")]
        public virtual void PutIdle(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpIdle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpIdle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest\"}}]")]
        public virtual void PutPerRequest(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetIdle")]
        public virtual void ResetIdle()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetPerRequest")]
        public virtual void ResetPerRequest()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpIdleOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpIdleOutputReference Idle
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpIdleOutputReference>()!;
        }

        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpPerRequestOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpPerRequestOutputReference PerRequest
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpPerRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpIdle\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpIdle? IdleInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpIdle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perRequestInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest? PerRequestInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttpPerRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp?>();
            set => SetInstanceProperty(value);
        }
    }
}
