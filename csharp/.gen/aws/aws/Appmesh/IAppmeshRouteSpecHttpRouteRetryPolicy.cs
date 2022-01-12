using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiInterface(nativeType: typeof(IAppmeshRouteSpecHttpRouteRetryPolicy), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicy")]
    public interface IAppmeshRouteSpecHttpRouteRetryPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#max_retries AppmeshRoute#max_retries}.</summary>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
        double MaxRetries
        {
            get;
        }

        /// <summary>per_retry_timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#per_retry_timeout AppmeshRoute#per_retry_timeout}
        /// </remarks>
        [JsiiProperty(name: "perRetryTimeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout\"}")]
        aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout PerRetryTimeout
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http_retry_events AppmeshRoute#http_retry_events}.</summary>
        [JsiiProperty(name: "httpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? HttpRetryEvents
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#tcp_retry_events AppmeshRoute#tcp_retry_events}.</summary>
        [JsiiProperty(name: "tcpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? TcpRetryEvents
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppmeshRouteSpecHttpRouteRetryPolicy), fullyQualifiedName: "aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicy")]
        internal sealed class _Proxy : DeputyBase, aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#max_retries AppmeshRoute#max_retries}.</summary>
            [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxRetries
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>per_retry_timeout block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#per_retry_timeout AppmeshRoute#per_retry_timeout}
            /// </remarks>
            [JsiiProperty(name: "perRetryTimeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout\"}")]
            public aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout PerRetryTimeout
            {
                get => GetInstanceProperty<aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http_retry_events AppmeshRoute#http_retry_events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "httpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? HttpRetryEvents
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#tcp_retry_events AppmeshRoute#tcp_retry_events}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "tcpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? TcpRetryEvents
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
