using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.S3
{
    [JsiiClass(nativeType: typeof(aws.S3.S3ControlObjectLambdaAccessPointConfigurationOutputReference), fullyQualifiedName: "aws.s3.S3ControlObjectLambdaAccessPointConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class S3ControlObjectLambdaAccessPointConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public S3ControlObjectLambdaAccessPointConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlObjectLambdaAccessPointConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected S3ControlObjectLambdaAccessPointConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetAllowedFeatures")]
        public virtual void ResetAllowedFeatures()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetCloudWatchMetricsEnabled")]
        public virtual void ResetCloudWatchMetricsEnabled()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "allowedFeaturesInput", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual string[]? AllowedFeaturesInput
        {
            get => GetInstanceProperty<string[]?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "cloudWatchMetricsEnabledInput", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        public virtual object? CloudWatchMetricsEnabledInput
        {
            get => GetInstanceProperty<object?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "supportingAccessPointInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SupportingAccessPointInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "transformationConfigurationInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration[]? TransformationConfigurationInput
        {
            get => GetInstanceProperty<aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration[]?>();
        }

        [JsiiProperty(name: "allowedFeatures", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] AllowedFeatures
        {
            get => GetInstanceProperty<string[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "cloudWatchMetricsEnabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public virtual object CloudWatchMetricsEnabled
        {
            get => GetInstanceProperty<object>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "supportingAccessPoint", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SupportingAccessPoint
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "transformationConfiguration", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration\"},\"kind\":\"array\"}}")]
        public virtual aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration[] TransformationConfiguration
        {
            get => GetInstanceProperty<aws.S3.IS3ControlObjectLambdaAccessPointConfigurationTransformationConfiguration[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.s3.S3ControlObjectLambdaAccessPointConfiguration\"}", isOptional: true)]
        public virtual aws.S3.IS3ControlObjectLambdaAccessPointConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.S3.IS3ControlObjectLambdaAccessPointConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
