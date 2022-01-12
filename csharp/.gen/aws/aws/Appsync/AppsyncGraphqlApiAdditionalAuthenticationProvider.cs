using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProvider")]
    public class AppsyncGraphqlApiAdditionalAuthenticationProvider : aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProvider
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#authentication_type AppsyncGraphqlApi#authentication_type}.</summary>
        [JsiiProperty(name: "authenticationType", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AuthenticationType
        {
            get;
            set;
        }

        /// <summary>lambda_authorizer_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#lambda_authorizer_config AppsyncGraphqlApi#lambda_authorizer_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "lambdaAuthorizerConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig\"}", isOptional: true, isOverride: true)]
        public aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig? LambdaAuthorizerConfig
        {
            get;
            set;
        }

        /// <summary>openid_connect_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#openid_connect_config AppsyncGraphqlApi#openid_connect_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "openidConnectConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig\"}", isOptional: true, isOverride: true)]
        public aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig? OpenidConnectConfig
        {
            get;
            set;
        }

        /// <summary>user_pool_config block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#user_pool_config AppsyncGraphqlApi#user_pool_config}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "userPoolConfig", typeJson: "{\"fqn\":\"aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig\"}", isOptional: true, isOverride: true)]
        public aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderUserPoolConfig? UserPoolConfig
        {
            get;
            set;
        }
    }
}
