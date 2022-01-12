using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2OutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2OutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualNodeSpecListenerTimeoutHttp2OutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualNodeSpecListenerTimeoutHttp2OutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutHttp2OutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualNodeSpecListenerTimeoutHttp2OutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2Idle\"}}]")]
        public virtual void PutIdle(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2Idle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2Idle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequest\"}}]")]
        public virtual void PutPerRequest(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequest)}, new object[]{@value});
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

        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2IdleOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2IdleOutputReference Idle
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2IdleOutputReference>()!;
        }

        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequestOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequestOutputReference PerRequest
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2Idle\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2Idle? IdleInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2Idle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perRequestInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequest\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequest? PerRequestInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2PerRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualNodeSpecListenerTimeoutHttp2\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualNodeSpecListenerTimeoutHttp2?>();
            set => SetInstanceProperty(value);
        }
    }
}
