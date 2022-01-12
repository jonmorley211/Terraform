using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshGatewayRouteSpecOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshGatewayRouteSpecOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshGatewayRouteSpecOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putGrpcRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRoute\"}}]")]
        public virtual void PutGrpcRoute(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttp2Route", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2Route\"}}]")]
        public virtual void PutHttp2Route(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route)}, new object[]{@value});
        }

        [JsiiMethod(name: "putHttpRoute", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRoute\"}}]")]
        public virtual void PutHttpRoute(aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetGrpcRoute")]
        public virtual void ResetGrpcRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttp2Route")]
        public virtual void ResetHttp2Route()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetHttpRoute")]
        public virtual void ResetHttpRoute()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "grpcRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteOutputReference GrpcRoute
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteOutputReference>()!;
        }

        [JsiiProperty(name: "http2Route", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteOutputReference Http2Route
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteOutputReference>()!;
        }

        [JsiiProperty(name: "httpRoute", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRouteOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteOutputReference HttpRoute
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecHttpRouteOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "grpcRouteInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute? GrpcRouteInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "http2RouteInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2Route\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route? Http2RouteInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2Route?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "httpRouteInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttpRoute\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute? HttpRouteInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttpRoute?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpec\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpec? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpec?>();
            set => SetInstanceProperty(value);
        }
    }
}
