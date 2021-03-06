using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appsync
{
    [JsiiInterface(nativeType: typeof(IAppsyncResolverCachingConfig), fullyQualifiedName: "aws.appsync.AppsyncResolverCachingConfig")]
    public interface IAppsyncResolverCachingConfig
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#caching_keys AppsyncResolver#caching_keys}.</summary>
        [JsiiProperty(name: "cachingKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? CachingKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#ttl AppsyncResolver#ttl}.</summary>
        [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Ttl
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IAppsyncResolverCachingConfig), fullyQualifiedName: "aws.appsync.AppsyncResolverCachingConfig")]
        internal sealed class _Proxy : DeputyBase, aws.Appsync.IAppsyncResolverCachingConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#caching_keys AppsyncResolver#caching_keys}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "cachingKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? CachingKeys
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/appsync_resolver#ttl AppsyncResolver#ttl}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "ttl", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Ttl
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
