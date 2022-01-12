using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Dlm
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRule")]
    public class DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRule : aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRule
    {
        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#encrypted DlmLifecyclePolicy#encrypted}.</summary>
        [JsiiProperty(name: "encrypted", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOverride: true)]
        public object Encrypted
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#target DlmLifecyclePolicy#target}.</summary>
        [JsiiProperty(name: "target", typeJson: "{\"primitive\":\"string\"}", isOverride: true)]
        public string Target
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#cmk_arn DlmLifecyclePolicy#cmk_arn}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "cmkArn", typeJson: "{\"primitive\":\"string\"}", isOptional: true, isOverride: true)]
        public string? CmkArn
        {
            get;
            set;
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#copy_tags DlmLifecyclePolicy#copy_tags}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "copyTags", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}", isOptional: true, isOverride: true)]
        public object? CopyTags
        {
            get;
            set;
        }

        /// <summary>deprecate_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#deprecate_rule DlmLifecyclePolicy#deprecate_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecateRule", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule\"}", isOptional: true, isOverride: true)]
        public aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleDeprecateRule? DeprecateRule
        {
            get;
            set;
        }

        /// <summary>retain_rule block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/aws/r/dlm_lifecycle_policy#retain_rule DlmLifecyclePolicy#retain_rule}
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retainRule", typeJson: "{\"fqn\":\"aws.dlm.DlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleRetainRule\"}", isOptional: true, isOverride: true)]
        public aws.Dlm.IDlmLifecyclePolicyPolicyDetailsScheduleCrossRegionCopyRuleRetainRule? RetainRule
        {
            get;
            set;
        }
    }
}
