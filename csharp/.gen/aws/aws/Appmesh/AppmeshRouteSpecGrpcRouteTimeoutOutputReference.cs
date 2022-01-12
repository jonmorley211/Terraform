using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshRouteSpecGrpcRouteTimeoutOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshRouteSpecGrpcRouteTimeoutOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshRouteSpecGrpcRouteTimeoutOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecGrpcRouteTimeoutOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshRouteSpecGrpcRouteTimeoutOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putIdle", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutIdle\"}}]")]
        public virtual void PutIdle(aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutIdle @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutIdle)}, new object[]{@value});
        }

        [JsiiMethod(name: "putPerRequest", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutPerRequest\"}}]")]
        public virtual void PutPerRequest(aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest)}, new object[]{@value});
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

        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutIdleOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecGrpcRouteTimeoutIdleOutputReference Idle
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecGrpcRouteTimeoutIdleOutputReference>()!;
        }

        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutPerRequestOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshRouteSpecGrpcRouteTimeoutPerRequestOutputReference PerRequest
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshRouteSpecGrpcRouteTimeoutPerRequestOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "idleInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutIdle\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutIdle? IdleInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutIdle?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "perRequestInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutPerRequest\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest? PerRequestInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeout\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout?>();
            set => SetInstanceProperty(value);
        }
    }
}
