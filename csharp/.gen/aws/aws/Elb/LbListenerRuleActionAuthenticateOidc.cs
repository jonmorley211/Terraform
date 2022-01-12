using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.LbListenerRuleActionAuthenticateOidc")]
    public class LbListenerRuleActionAuthenticateOidc : aws.Elb.ILbListenerRuleActionAuthenticateOidc
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#authorization_endpoint LbListenerRule#authorization_endpoint}.</summary>
        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AuthorizationEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#client_id LbListenerRule#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#client_secret LbListenerRule#client_secret}.</summary>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClientSecret
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#issuer LbListenerRule#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Issuer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#token_endpoint LbListenerRule#token_endpoint}.</summary>
        [JsiiProperty(name: "tokenEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TokenEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#user_info_endpoint LbListenerRule#user_info_endpoint}.</summary>
        [JsiiProperty(name: "userInfoEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserInfoEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#authentication_request_extra_params LbListenerRule#authentication_request_extra_params}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? AuthenticationRequestExtraParams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#on_unauthenticated_request LbListenerRule#on_unauthenticated_request}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OnUnauthenticatedRequest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#scope LbListenerRule#scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Scope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#session_cookie_name LbListenerRule#session_cookie_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SessionCookieName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/lb_listener_rule#session_timeout LbListenerRule#session_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? SessionTimeout
        {
            get;
            set;
        }
    }
}
