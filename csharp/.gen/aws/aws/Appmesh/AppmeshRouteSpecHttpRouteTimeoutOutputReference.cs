using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecHttpRouteTimeoutOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecHttpRouteTimeoutOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecHttpRouteTimeoutOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteTimeoutOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttpRouteTimeoutOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutIdle\"}}]")]
        public virtual void PutIdle(aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutIdle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutIdle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutPerRequest\"}}]")]
        public virtual void PutPerRequest(aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutPerRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutPerRequest)}, new object[]{@value});
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

        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutIdleOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteTimeoutIdleOutputReference Idle
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteTimeoutIdleOutputReference>()!;
        }

        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutPerRequestOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttpRouteTimeoutPerRequestOutputReference PerRequest
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttpRouteTimeoutPerRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutIdle\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutIdle? IdleInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutIdle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perRequestInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutPerRequest\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutPerRequest? PerRequestInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutPerRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeout\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeout? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeout?>();
            set => SetInstanceProperty(value);
        }
    }
}
