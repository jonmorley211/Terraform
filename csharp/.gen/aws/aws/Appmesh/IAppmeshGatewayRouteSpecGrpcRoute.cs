using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshGatewayRouteSpecGrpcRoute), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRoute")]
    public interface IAppmeshGatewayRouteSpecGrpcRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#action AppmeshGatewayRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteAction\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#match AppmeshGatewayRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteMatch\"}")]
        aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteMatch Match
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshGatewayRouteSpecGrpcRoute), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRoute")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#action AppmeshGatewayRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteAction\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction Action
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_gateway_route#match AppmeshGatewayRoute#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteMatch\"}")]
            public aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteMatch Match
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteMatch>()!;
            }
        }
    }
}
