using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Route53
{
    [JsiiInterface(nativeType: typeof(IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource), fullyQualifiedName: "aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource")]
    public interface IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#arn Route53RecoveryreadinessResourceSet#arn}.</summary>
        [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Arn
        {
            get
            {
                return null;
            }
        }

        [JsiiTypeProxy(nativeType: typeof(IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource), fullyQualifiedName: "aws.route53.Route53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource")]
        internal sealed class _Proxy : DeputyBase, aws.Route53.IRoute53RecoveryreadinessResourceSetResourcesDnsTargetResourceTargetResourceNlbResource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/route53recoveryreadiness_resource_set#arn Route53RecoveryreadinessResourceSet#arn}.</summary>
            [JsiiOptional]
            [JsiiProperty(name: "arn", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Arn
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
