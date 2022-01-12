using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.appsync.AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig")]
    public class AppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig : aws.Appsync.IAppsyncGraphqlApiAdditionalAuthenticationProviderOpenidConnectConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#issuer AppsyncGraphqlApi#issuer}.</summary>
        [JsiiProperty(name: "issuer", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Issuer
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#auth_ttl AppsyncGraphqlApi#auth_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "authTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? AuthTtl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#client_id AppsyncGraphqlApi#client_id}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "clientId", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? ClientId
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_graphql_api#iat_ttl AppsyncGraphqlApi#iat_ttl}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "iatTtl", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? IatTtl
        {
            get;
            set;
        }
    }
}
