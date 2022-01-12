using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2RuleGroupRuleActionBlockOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2RuleGroupRuleActionBlockOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2RuleGroupRuleActionBlockOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2RuleGroupRuleActionBlockOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleActionBlockOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2RuleGroupRuleActionBlockOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putCustomResponse", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponse\"}}]")]
        public virtual void PutCustomResponse(aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetCustomResponse")]
        public virtual void ResetCustomResponse()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "customResponse", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponseOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2RuleGroupRuleActionBlockCustomResponseOutputReference CustomResponse
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2RuleGroupRuleActionBlockCustomResponseOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "customResponseInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlockCustomResponse\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse? CustomResponseInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionBlockCustomResponse?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2RuleGroupRuleActionBlock\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2RuleGroupRuleActionBlock? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2RuleGroupRuleActionBlock?>();
            set => SetInstanceProperty(value);
        }
    }
}
