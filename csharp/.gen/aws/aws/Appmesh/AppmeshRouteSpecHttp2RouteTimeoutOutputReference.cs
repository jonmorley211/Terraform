using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecHttp2RouteTimeoutOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecHttp2RouteTimeoutOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecHttp2RouteTimeoutOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttp2RouteTimeoutOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecHttp2RouteTimeoutOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutIdle\"}}]")]
        public virtual void PutIdle(aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutIdle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutIdle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutPerRequest\"}}]")]
        public virtual void PutPerRequest(aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutPerRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutPerRequest)}, new object[]{@value});
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

        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutIdleOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttp2RouteTimeoutIdleOutputReference Idle
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttp2RouteTimeoutIdleOutputReference>()!;
        }

        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutPerRequestOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecHttp2RouteTimeoutPerRequestOutputReference PerRequest
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecHttp2RouteTimeoutPerRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutIdle\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutIdle? IdleInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutIdle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perRequestInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutPerRequest\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutPerRequest? PerRequestInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutPerRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeout\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout?>();
            set => SetInstanceProperty(value);
        }
    }
}
