using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecTcpRouteTimeout), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecTcpRouteTimeout")]
    public interface IAppmeshRouteSpecTcpRouteTimeout
    {
        /// <summary>idle block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
        /// </remarks>
        [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteTimeoutIdle\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeoutIdle? Idle
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecTcpRouteTimeout), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecTcpRouteTimeout")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeout
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>idle block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#idle AppmeshRoute#idle}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "idle", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteTimeoutIdle\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeoutIdle? Idle
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeoutIdle?>();
            }
        }
    }
}
