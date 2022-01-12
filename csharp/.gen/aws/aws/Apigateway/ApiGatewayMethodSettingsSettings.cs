using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigateway
{
    [JsiiByValue(fqn: "aws.apigateway.ApiGatewayMethodSettingsSettings")]
    public class ApiGatewayMethodSettingsSettings : aws.Apigateway.IApiGatewayMethodSettingsSettings
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#cache_data_encrypted ApiGatewayMethodSettings#cache_data_encrypted}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheDataEncrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? CacheDataEncrypted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#cache_ttl_in_seconds ApiGatewayMethodSettings#cache_ttl_in_seconds}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cacheTtlInSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? CacheTtlInSeconds
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#caching_enabled ApiGatewayMethodSettings#caching_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cachingEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? CachingEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#data_trace_enabled ApiGatewayMethodSettings#data_trace_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "dataTraceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? DataTraceEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#logging_level ApiGatewayMethodSettings#logging_level}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "loggingLevel", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? LoggingLevel
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#metrics_enabled ApiGatewayMethodSettings#metrics_enabled}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "metricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? MetricsEnabled
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#require_authorization_for_cache_control ApiGatewayMethodSettings#require_authorization_for_cache_control}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "requireAuthorizationForCacheControl", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? RequireAuthorizationForCacheControl
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#throttling_burst_limit ApiGatewayMethodSettings#throttling_burst_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "throttlingBurstLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ThrottlingBurstLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#throttling_rate_limit ApiGatewayMethodSettings#throttling_rate_limit}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "throttlingRateLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true, isOverride: true)]
        public double? ThrottlingRateLimit
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/api_gateway_method_settings#unauthorized_cache_control_header_strategy ApiGatewayMethodSettings#unauthorized_cache_control_header_strategy}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "unauthorizedCacheControlHeaderStrategy", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? UnauthorizedCacheControlHeaderStrategy
        {
            get;
            set;
        }
    }
}
