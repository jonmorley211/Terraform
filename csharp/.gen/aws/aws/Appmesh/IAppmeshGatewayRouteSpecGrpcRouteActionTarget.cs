using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecGrpcRouteActionTarget), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTarget")]
    public interface IAppmeshGatewayRouteSpecGrpcRouteActionTarget
    {
        /// <summary>virtual_service block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service AppmeshGatewayRoute#virtual_service}
        /// </remarks>
        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService VirtualService
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecGrpcRouteActionTarget), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTarget")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>virtual_service block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#virtual_service AppmeshGatewayRoute#virtual_service}
            /// </remarks>
            [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService VirtualService
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService>()!;
            }
        }
    }
}
