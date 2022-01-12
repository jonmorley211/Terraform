using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecTcpRoute), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecTcpRoute")]
    public interface IAppmeshRouteSpecTcpRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteAction\"}")]
        aws.Appmesh.IAppmeshRouteSpecTcpRouteAction Action
        {
            get;
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#timeout AppmeshRoute#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecTcpRoute), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecTcpRoute")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecTcpRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteAction\"}")]
            public aws.Appmesh.IAppmeshRouteSpecTcpRouteAction Action
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecTcpRouteAction>()!;
            }

            /// <summary>timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#timeout AppmeshRoute#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecTcpRouteTimeout\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeout? Timeout
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecTcpRouteTimeout?>();
            }
        }
    }
}
