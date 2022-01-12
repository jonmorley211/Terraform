using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecGrpcRouteTimeout), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecGrpcRouteTimeout")]
    public interface IAppmeshRouteSpecGrpcRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutIdle? Idle
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
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutPerRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest? PerRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecGrpcRouteTimeout), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecGrpcRouteTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutIdle\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutIdle? Idle
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutIdle?>();
            }

            /// <summary>per_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#per_request AppmeshRoute#per_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeoutPerRequest\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest? PerRequest
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeoutPerRequest?>();
            }
        }
    }
}
