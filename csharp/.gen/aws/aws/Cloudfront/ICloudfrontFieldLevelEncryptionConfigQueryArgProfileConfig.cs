using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Cloudfront
{
    [JsiiInterface(nativeType: typeof(ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig")]
    public interface ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#forward_when_query_arg_profile_is_unknown CloudfrontFieldLevelEncryptionConfig#forward_when_query_arg_profile_is_unknown}.</summary>
        [JsiiProperty(name: "forwardWhenQueryArgProfileIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        object ForwardWhenQueryArgProfileIsUnknown
        {
            get;
        }

        /// <summary>query_arg_profiles block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#query_arg_profiles CloudfrontFieldLevelEncryptionConfig#query_arg_profiles}
        /// </remarks>
        [JsiiProperty(name: "queryArgProfiles", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles? QueryArgProfiles
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig), fullyQualifiedName: "aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#forward_when_query_arg_profile_is_unknown CloudfrontFieldLevelEncryptionConfig#forward_when_query_arg_profile_is_unknown}.</summary>
            [JsiiProperty(name: "forwardWhenQueryArgProfileIsUnknown", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
            public object ForwardWhenQueryArgProfileIsUnknown
            {
                get => GetInstanceProperty<object>()!;
            }

            /// <summary>query_arg_profiles block.</summary>
            /// <remarks>
            /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/cloudfront_field_level_encryption_config#query_arg_profiles CloudfrontFieldLevelEncryptionConfig#query_arg_profiles}
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queryArgProfiles", typeJson: "{\"fqn\":\"aws.cloudfront.CloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles\"}", isOptional: true)]
            public aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles? QueryArgProfiles
            {
                get => GetInstanceProperty<aws.Cloudfront.ICloudfrontFieldLevelEncryptionConfigQueryArgProfileConfigQueryArgProfiles?>();
            }
        }
    }
}
