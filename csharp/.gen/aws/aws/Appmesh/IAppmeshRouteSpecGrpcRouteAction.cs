using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecGrpcRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecGrpcRouteAction")]
    public interface IAppmeshRouteSpecGrpcRouteAction
    {
        /// <summary>weighted_target block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
        /// </remarks>
        [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
        aws.Appmesh.IAppmeshRouteSpecGrpcRouteActionWeightedTarget[] WeightedTarget
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecGrpcRouteAction), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecGrpcRouteAction")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecGrpcRouteAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>weighted_target block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#weighted_target AppmeshRoute#weighted_target}
            /// </remarks>
            [JsiiProperty(name: "weightedTarget", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteActionWeightedTarget\"},\"kind\":\"array\"}}")]
            public aws.Appmesh.IAppmeshRouteSpecGrpcRouteActionWeightedTarget[] WeightedTarget
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteActionWeightedTarget[]>()!;
            }
        }
    }
}
