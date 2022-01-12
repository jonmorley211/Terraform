using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttp2RouteTimeout), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttp2RouteTimeout")]
    public interface IAppmeshRouteSpecHttp2RouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutIdle? Idle
        {
            get
            {
                return null;
            }
        }

        /// <summary>per_request block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#per_request AppmeshRoute#per_request}
        /// </remarks>
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutPerRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutPerRequest? PerRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttp2RouteTimeout), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttp2RouteTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutIdle\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutIdle? Idle
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutIdle?>();
            }

            /// <summary>per_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#per_request AppmeshRoute#per_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeoutPerRequest\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutPerRequest? PerRequest
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeoutPerRequest?>();
            }
        }
    }
}
