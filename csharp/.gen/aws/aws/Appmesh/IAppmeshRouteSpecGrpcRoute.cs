using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecGrpcRoute), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecGrpcRoute")]
    public interface IAppmeshRouteSpecGrpcRoute
    {
        /// <summary>action block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteAction\"}")]
        aws.Appmesh.IAppmeshRouteSpecGrpcRouteAction Action
        {
            get;
        }

        /// <summary>match block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
        /// </remarks>
        [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteMatch\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecGrpcRouteMatch? Match
        {
            get
            {
                return null;
            }
        }

        /// <summary>retry_policy block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#retry_policy AppmeshRoute#retry_policy}
        /// </remarks>
        [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteRetryPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecGrpcRouteRetryPolicy? RetryPolicy
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
        [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeout\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout? Timeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecGrpcRoute), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecGrpcRoute")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecGrpcRoute
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>action block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#action AppmeshRoute#action}
            /// </remarks>
            [JsiiProperty(name: "action", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteAction\"}")]
            public aws.Appmesh.IAppmeshRouteSpecGrpcRouteAction Action
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteAction>()!;
            }

            /// <summary>match block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#match AppmeshRoute#match}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "match", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteMatch\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecGrpcRouteMatch? Match
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteMatch?>();
            }

            /// <summary>retry_policy block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#retry_policy AppmeshRoute#retry_policy}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "retryPolicy", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteRetryPolicy\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecGrpcRouteRetryPolicy? RetryPolicy
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteRetryPolicy?>();
            }

            /// <summary>timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#timeout AppmeshRoute#timeout}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecGrpcRouteTimeout\"}", isOptional: true)]
            public aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout? Timeout
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecGrpcRouteTimeout?>();
            }
        }
    }
}
