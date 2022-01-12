using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicy")]
    public class AppmeshRouteSpecHttpRouteRetryPolicy : aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicy
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#max_retries AppmeshRoute#max_retries}.</summary>
        [JsiiProperty(name: "maxRetries", typeJson: "{\"primitive\":\"number\"}", isOverride: true)]
        public double MaxRetries
        {
            get;
            set;
        }

        /// <summary>per_retry_timeout block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#per_retry_timeout AppmeshRoute#per_retry_timeout}
        /// </remarks>
        [JsiiProperty(name: "perRetryTimeout", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout\"}", isOverride: true)]
        public aws.Appmesh.IAppmeshRouteSpecHttpRouteRetryPolicyPerRetryTimeout PerRetryTimeout
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#http_retry_events AppmeshRoute#http_retry_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "httpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? HttpRetryEvents
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appmesh_route#tcp_retry_events AppmeshRoute#tcp_retry_events}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "tcpRetryEvents", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true, isOverride: true)]
        public string[]? TcpRetryEvents
        {
            get;
            set;
        }
    }
}
