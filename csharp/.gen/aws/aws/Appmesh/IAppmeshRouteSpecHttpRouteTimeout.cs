using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteTimeout), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteTimeout")]
    public interface IAppmeshRouteSpecHttpRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutIdle? Idle
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
        [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutPerRequest\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutPerRequest? PerRequest
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteTimeout), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutIdle\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutIdle? Idle
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutIdle?>();
            }

            /// <summary>per_request block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#per_request AppmeshRoute#per_request}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "perRequest", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteTimeoutPerRequest\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutPerRequest? PerRequest
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteTimeoutPerRequest?>();
            }
        }
    }
}
