using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    [JsiiInterface(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleRetainRule), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleRetainRule")]
    public interface IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleRetainRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval DlmLifecyclePolicy#interval}.</summary>
        [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
        double Interval
        {
            get;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval_unit DlmLifecyclePolicy#interval_unit}.</summary>
        [JsiiProperty(name: "intervalUnit", typeJson: "{\"primitive\":\"string\"}")]
        string IntervalUnit
        {
            get;
        }

        [JsiiTypeProxy(nativeType: typeof(IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleRetainRule), fullyQualifiedName: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleRetainRule")]
        internal sealed class _Proxy : DeputyBase, aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleRetainRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval DlmLifecyclePolicy#interval}.</summary>
            [JsiiProperty(name: "interval", typeJson: "{\"primitive\":\"number\"}")]
            public double Interval
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#interval_unit DlmLifecyclePolicy#interval_unit}.</summary>
            [JsiiProperty(name: "intervalUnit", typeJson: "{\"primitive\":\"string\"}")]
            public string IntervalUnit
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
