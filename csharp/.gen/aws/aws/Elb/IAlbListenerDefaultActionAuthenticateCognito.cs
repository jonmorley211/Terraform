using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Elb
{
    [JsiiInterface(nativeType: typeof(IAlbListenerDefaultActionAuthenticateCognito), fullyQualifiedName: "aws.elb.AlbListenerDefaultActionAuthenticateCognito")]
    public interface IAlbListenerDefaultActionAuthenticateCognito
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#user_pool_arn AlbListener#user_pool_arn}.</summary>
        [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolArn
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#user_pool_client_id AlbListener#user_pool_client_id}.</summary>
        [JsiiProperty(name: "userPoolClientId", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolClientId
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#user_pool_domain AlbListener#user_pool_domain}.</summary>
        [JsiiProperty(name: "userPoolDomain", typeJson: "{\"primitive\":\"string\"}")]
        string UserPoolDomain
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#authentication_request_extra_params AlbListener#authentication_request_extra_params}.</summary>
        [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"union\":{\"types\":[{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? AuthenticationRequestExtraParams
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#on_unauthenticated_request AlbListener#on_unauthenticated_request}.</summary>
        [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? OnUnauthenticatedRequest
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#scope AlbListener#scope}.</summary>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Scope
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#session_cookie_name AlbListener#session_cookie_name}.</summary>
        [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SessionCookieName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#session_timeout AlbListener#session_timeout}.</summary>
        [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SessionTimeout
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAlbListenerDefaultActionAuthenticateCognito), fullyQualifiedName: "aws.elb.AlbListenerDefaultActionAuthenticateCognito")]
        internal sealed class _Proxy : DeputyBase, aws.Elb.IAlbListenerDefaultActionAuthenticateCognito
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#user_pool_arn AlbListener#user_pool_arn}.</summary>
            [JsiiProperty(name: "userPoolArn", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolArn
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#user_pool_client_id AlbListener#user_pool_client_id}.</summary>
            [JsiiProperty(name: "userPoolClientId", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolClientId
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#user_pool_domain AlbListener#user_pool_domain}.</summary>
            [JsiiProperty(name: "userPoolDomain", typeJson: "{\"primitive\":\"string\"}")]
            public string UserPoolDomain
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#authentication_request_extra_params AlbListener#authentication_request_extra_params}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "authenticationRequestExtraParams", typeJson: "{\"union\":{\"types\":[{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? AuthenticationRequestExtraParams
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#on_unauthenticated_request AlbListener#on_unauthenticated_request}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "onUnauthenticatedRequest", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? OnUnauthenticatedRequest
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#scope AlbListener#scope}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Scope
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#session_cookie_name AlbListener#session_cookie_name}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sessionCookieName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SessionCookieName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/alb_listener#session_timeout AlbListener#session_timeout}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "sessionTimeout", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SessionTimeout
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
