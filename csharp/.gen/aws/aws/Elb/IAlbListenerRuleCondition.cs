using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IAlbListenerRuleCondition), fullyQualifiedName: "aws.elb.AlbListenerRuleCondition")]
    public interface IAlbListenerRuleCondition
    {
        /// <summary>host_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#host_header AlbListenerRule#host_header}
        /// </remarks>
        [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionHostHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleConditionHostHeader? HostHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_header block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#http_header AlbListenerRule#http_header}
        /// </remarks>
        [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionHttpHeader\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleConditionHttpHeader? HttpHeader
        {
            get
            {
                return null;
            }
        }

        /// <summary>http_request_method block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#http_request_method AlbListenerRule#http_request_method}
        /// </remarks>
        [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
        {
            get
            {
                return null;
            }
        }

        /// <summary>path_pattern block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#path_pattern AlbListenerRule#path_pattern}
        /// </remarks>
        [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionPathPattern\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleConditionPathPattern? PathPattern
        {
            get
            {
                return null;
            }
        }

        /// <summary>query_string block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#query_string AlbListenerRule#query_string}
        /// </remarks>
        [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleConditionQueryString[]? QueryString
        {
            get
            {
                return null;
            }
        }

        /// <summary>source_ip block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#source_ip AlbListenerRule#source_ip}
        /// </remarks>
        [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionSourceIp\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Elb.IAlbListenerRuleConditionSourceIp? SourceIp
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerRuleCondition), fullyQualifiedName: "aws.elb.AlbListenerRuleCondition")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbListenerRuleCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>host_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#host_header AlbListenerRule#host_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostHeader", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionHostHeader\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleConditionHostHeader? HostHeader
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleConditionHostHeader?>();
            }

            /// <summary>http_header block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#http_header AlbListenerRule#http_header}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpHeader", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionHttpHeader\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleConditionHttpHeader? HttpHeader
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleConditionHttpHeader?>();
            }

            /// <summary>http_request_method block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#http_request_method AlbListenerRule#http_request_method}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "httpRequestMethod", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionHttpRequestMethod\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleConditionHttpRequestMethod? HttpRequestMethod
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleConditionHttpRequestMethod?>();
            }

            /// <summary>path_pattern block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#path_pattern AlbListenerRule#path_pattern}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "pathPattern", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionPathPattern\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleConditionPathPattern? PathPattern
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleConditionPathPattern?>();
            }

            /// <summary>query_string block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#query_string AlbListenerRule#query_string}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryString", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.elb.AlbListenerRuleConditionQueryString\"},\"kind\":\"array\"}}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleConditionQueryString[]? QueryString
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleConditionQueryString[]?>();
            }

            /// <summary>source_ip block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#source_ip AlbListenerRule#source_ip}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sourceIp", typeJson: "{\"fqn\":\"aws.elb.AlbListenerRuleConditionSourceIp\"}", isOptional: true)]
            public aws.Elb.IAlbListenerRuleConditionSourceIp? SourceIp
            {
                get => GetInstanceProperty<aws.Elb.IAlbListenerRuleConditionSourceIp?>();
            }
        }
    }
}
