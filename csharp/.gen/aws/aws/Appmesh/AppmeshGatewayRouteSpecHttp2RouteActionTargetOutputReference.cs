using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecHttp2RouteActionTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVirtualService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService\"}}]")]
        public virtual void PutVirtualService(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService)}, new object[]{@value});
        }

        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualServiceOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualServiceOutputReference VirtualService
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualServiceInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService? VirtualServiceInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTargetVirtualService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecHttp2RouteActionTarget\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecHttp2RouteActionTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
