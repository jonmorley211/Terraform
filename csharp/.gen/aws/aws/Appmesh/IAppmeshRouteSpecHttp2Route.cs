using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttp2Route), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttp2Route")]
    public interface IAppmeshRouteSpecHttp2Route
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteAction\"}")]
        aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatch\"}")]
        aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatch Match
        {
            get;
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#retry_policy AppmeshRoute#retry_policy}
        /// </remarks>
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteRetryPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttp2RouteRetryPolicy? RetryPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#timeout AppmeshRoute#timeout}
        /// </remarks>
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttp2Route), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttp2Route")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttp2Route
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteAction\"}")]
            public aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction Action
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
            /// </remarks>
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteMatch\"}")]
            public aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatch Match
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteMatch>()!;
            }

            /// <summary>retry_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#retry_policy AppmeshRoute#retry_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteRetryPolicy\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttp2RouteRetryPolicy? RetryPolicy
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteRetryPolicy?>();
            }

            /// <summary>timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#timeout AppmeshRoute#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttp2RouteTimeout\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout? Timeout
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttp2RouteTimeout?>();
            }
        }
    }
}
