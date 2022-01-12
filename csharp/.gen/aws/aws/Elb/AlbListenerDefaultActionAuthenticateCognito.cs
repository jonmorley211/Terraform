using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.elb.AlbListenerDefaultActionAuthenticateCognito")]
    public class AlbListenerDefaultActionAuthenticateCognito : aws.Elb.IAlbListenerDefaultActionAuthenticateCognito
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#user_pool_arn AlbListener#user_pool_arn}.</summary>
        [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPoolArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#user_pool_client_id AlbListener#user_pool_client_id}.</summary>
        [JsiiProperty(name: "userPoolClientId", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPoolClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#user_pool_domain AlbListener#user_pool_domain}.</summary>
        [JsiiProperty(name: "userPoolDomain", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string UserPoolDomain
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#authentication_request_extra_params AlbListener#authentication_request_extra_params}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"union\":{\"types\":[{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? AuthenticationRequestExtraParams
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#on_unauthenticated_request AlbListener#on_unauthenticated_request}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? OnUnauthenticatedRequest
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#scope AlbListener#scope}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? Scope
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#session_cookie_name AlbListener#session_cookie_name}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? SessionCookieName
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#session_timeout AlbListener#session_timeout}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? SessionTimeout
        {
            get;
            set;
        }
    }
}
