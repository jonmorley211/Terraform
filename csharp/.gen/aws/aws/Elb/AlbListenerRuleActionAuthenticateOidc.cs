using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbListenerRuleActionAuthenticateOidc")]
    public class AlbListenerRuleActionAuthenticateOidc : aws.Elb.IAlbListenerRuleActionAuthenticateOidc
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#authorization_endpoint AlbListenerRule#authorization_endpoint}.</summary>
        [JsiiProperty(name: "authorizationEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AuthorizationEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#client_id AlbListenerRule#client_id}.</summary>
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#client_secret AlbListenerRule#client_secret}.</summary>
        [JsiiProperty(name: "clientSecret", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string ClientSecret
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#issuer AlbListenerRule#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Issuer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#token_endpoint AlbListenerRule#token_endpoint}.</summary>
        [JsiiProperty(name: "tokenEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string TokenEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#user_info_endpoint AlbListenerRule#user_info_endpoint}.</summary>
        [JsiiProperty(name: "userInfoEndpoint", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserInfoEndpoint
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#authentication_request_extra_params AlbListenerRule#authentication_request_extra_params}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}]}}", isOptional: true, isOverride: true)]
        public object? AuthenticationRequestExtraParams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#on_unauthenticated_request AlbListenerRule#on_unauthenticated_request}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OnUnauthenticatedRequest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#scope AlbListenerRule#scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Scope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#session_cookie_name AlbListenerRule#session_cookie_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SessionCookieName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener_rule#session_timeout AlbListenerRule#session_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? SessionTimeout
        {
            get;
            set;
        }
    }
}
