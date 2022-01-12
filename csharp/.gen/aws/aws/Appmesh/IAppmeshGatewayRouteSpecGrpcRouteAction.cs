using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecGrpcRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteAction")]
    public interface IAppmeshGatewayRouteSpecGrpcRouteAction
    {
        /// <summary>target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#target AppmeshGatewayRoute#target}
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTarget\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget Target
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecGrpcRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#target AppmeshGatewayRoute#target}
            /// </remarks>
            [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTarget\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget Target
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget>()!;
            }
        }
    }
}
