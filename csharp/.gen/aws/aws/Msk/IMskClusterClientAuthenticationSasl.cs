using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Msk
{
    [JsiiInterface(nativeType: typeof(IMskClusterClientAuthenticationSasl), fullyQualifiedName: "aws.msk.MskClusterClientAuthenticationSasl")]
    public interface IMskClusterClientAuthenticationSasl
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#iam MskCluster#iam}.</summary>
        [JsiiProperty(name: "iam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Iam
        {
            get
            {
                return null;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#scram MskCluster#scram}.</summary>
        [JsiiProperty(name: "scram", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Scram
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IMskClusterClientAuthenticationSasl), fullyQualifiedName: "aws.msk.MskClusterClientAuthenticationSasl")]
        internal sealed class _Proxy : DeputyBase, aws.Msk.IMskClusterClientAuthenticationSasl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#iam MskCluster#iam}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "iam", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Iam
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/msk_cluster#scram MskCluster#scram}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "scram", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true)]
            public object? Scram
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
