using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig")]
    public class AppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig : aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderLambdaAuthorizerConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#authorizer_uri AppsyncGraphqlApi#authorizer_uri}.</summary>
        [JsiiProperty(name: "authorizerUri", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string AuthorizerUri
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#authorizer_result_ttl_in_seconds AppsyncGraphqlApi#authorizer_result_ttl_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authorizerResultTtlInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AuthorizerResultTtlInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#identity_validation_expression AppsyncGraphqlApi#identity_validation_expression}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "identityValidationExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? IdentityValidationExpression
        {
            get;
            set;
        }
    }
}
