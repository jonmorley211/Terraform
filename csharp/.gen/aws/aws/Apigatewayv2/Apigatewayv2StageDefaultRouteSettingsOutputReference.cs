using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Apigatewayv2
{
    [JsiiClass(nativeType: typeof(aws.Apigatewayv2.Apigatewayv2StageDefaultRouteSettingsOutputReference), fullyQualifiedName: "aws.apigatewayv2.Apigatewayv2StageDefaultRouteSettingsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Apigatewayv2StageDefaultRouteSettingsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Apigatewayv2StageDefaultRouteSettingsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2StageDefaultRouteSettingsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Apigatewayv2StageDefaultRouteSettingsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetDataTraceEnabled")]
        public virtual void ResetDataTraceEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDetailedMetricsEnabled")]
        public virtual void ResetDetailedMetricsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLoggingLevel")]
        public virtual void ResetLoggingLevel()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThrottlingBurstLimit")]
        public virtual void ResetThrottlingBurstLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetThrottlingRateLimit")]
        public virtual void ResetThrottlingRateLimit()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "dataTraceEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DataTraceEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "detailedMetricsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? DetailedMetricsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "loggingLevelInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? LoggingLevelInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "throttlingBurstLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThrottlingBurstLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "throttlingRateLimitInput", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public virtual double? ThrottlingRateLimitInput
        {
            get => GetInstanceProperty<double?>();
        }

        [JsiiProperty(name: "dataTraceEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DataTraceEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "detailedMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object DetailedMetricsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "loggingLevel", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string LoggingLevel
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "throttlingBurstLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThrottlingBurstLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "throttlingRateLimit", typeJson: "{\"primitive\":\"number\"}")]
        public virtual double ThrottlingRateLimit
        {
            get => GetInstanceProperty<double>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.apigatewayv2.Apigatewayv2StageDefaultRouteSettings\"}", isOptional: true)]
        public virtual aws.Apigatewayv2.IApigatewayv2StageDefaultRouteSettings? InternalValue
        {
            get => GetInstanceProperty<aws.Apigatewayv2.IApigatewayv2StageDefaultRouteSettings?>();
            set => SetInstanceProperty(value);
        }
    }
}
