using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Wafv2
{
    [JsiiClass(nativeType: typeof(aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOutputReference), fullyQualifiedName: "aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAndStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatement\"}}]")]
        public virtual void PutAndStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putByteMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementByteMatchStatement\"}}]")]
        public virtual void PutByteMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementByteMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementByteMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putGeoMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementGeoMatchStatement\"}}]")]
        public virtual void PutGeoMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementGeoMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementGeoMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putIpSetReferenceStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementIpSetReferenceStatement\"}}]")]
        public virtual void PutIpSetReferenceStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementIpSetReferenceStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementIpSetReferenceStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putLabelMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementLabelMatchStatement\"}}]")]
        public virtual void PutLabelMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementLabelMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementLabelMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putNotStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatement\"}}]")]
        public virtual void PutNotStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putOrStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOrStatement\"}}]")]
        public virtual void PutOrStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOrStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOrStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putRegexPatternSetReferenceStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexPatternSetReferenceStatement\"}}]")]
        public virtual void PutRegexPatternSetReferenceStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexPatternSetReferenceStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexPatternSetReferenceStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSizeConstraintStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSizeConstraintStatement\"}}]")]
        public virtual void PutSizeConstraintStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSizeConstraintStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSizeConstraintStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putSqliMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSqliMatchStatement\"}}]")]
        public virtual void PutSqliMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSqliMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSqliMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "putXssMatchStatement", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement\"}}]")]
        public virtual void PutXssMatchStatement(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAndStatement")]
        public virtual void ResetAndStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetByteMatchStatement")]
        public virtual void ResetByteMatchStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetGeoMatchStatement")]
        public virtual void ResetGeoMatchStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetIpSetReferenceStatement")]
        public virtual void ResetIpSetReferenceStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetLabelMatchStatement")]
        public virtual void ResetLabelMatchStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetNotStatement")]
        public virtual void ResetNotStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetOrStatement")]
        public virtual void ResetOrStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetRegexPatternSetReferenceStatement")]
        public virtual void ResetRegexPatternSetReferenceStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSizeConstraintStatement")]
        public virtual void ResetSizeConstraintStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetSqliMatchStatement")]
        public virtual void ResetSqliMatchStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetXssMatchStatement")]
        public virtual void ResetXssMatchStatement()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "andStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementOutputReference AndStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatementOutputReference>()!;
        }

        [JsiiProperty(name: "byteMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementByteMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementByteMatchStatementOutputReference ByteMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementByteMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "geoMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementGeoMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementGeoMatchStatementOutputReference GeoMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementGeoMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "ipSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementIpSetReferenceStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementIpSetReferenceStatementOutputReference IpSetReferenceStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementIpSetReferenceStatementOutputReference>()!;
        }

        [JsiiProperty(name: "labelMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementLabelMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementLabelMatchStatementOutputReference LabelMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementLabelMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "notStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementOutputReference NotStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatementOutputReference>()!;
        }

        [JsiiProperty(name: "orStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOrStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOrStatementOutputReference OrStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOrStatementOutputReference>()!;
        }

        [JsiiProperty(name: "regexPatternSetReferenceStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexPatternSetReferenceStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexPatternSetReferenceStatementOutputReference RegexPatternSetReferenceStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexPatternSetReferenceStatementOutputReference>()!;
        }

        [JsiiProperty(name: "sizeConstraintStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSizeConstraintStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSizeConstraintStatementOutputReference SizeConstraintStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSizeConstraintStatementOutputReference>()!;
        }

        [JsiiProperty(name: "sqliMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSqliMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSqliMatchStatementOutputReference SqliMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSqliMatchStatementOutputReference>()!;
        }

        [JsiiProperty(name: "xssMatchStatement", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatementOutputReference\"}")]
        public virtual aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatementOutputReference XssMatchStatement
        {
            get => GetInstanceProperty<aws.Wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatementOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "andStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatement? AndStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementAndStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "byteMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementByteMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementByteMatchStatement? ByteMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementByteMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "geoMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementGeoMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementGeoMatchStatement? GeoMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementGeoMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "ipSetReferenceStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementIpSetReferenceStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementIpSetReferenceStatement? IpSetReferenceStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementIpSetReferenceStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "labelMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementLabelMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementLabelMatchStatement? LabelMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementLabelMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "notStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatement? NotStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementNotStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "orStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOrStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOrStatement? OrStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementOrStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "regexPatternSetReferenceStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexPatternSetReferenceStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexPatternSetReferenceStatement? RegexPatternSetReferenceStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementRegexPatternSetReferenceStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sizeConstraintStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSizeConstraintStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSizeConstraintStatement? SizeConstraintStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSizeConstraintStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "sqliMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSqliMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSqliMatchStatement? SqliMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementSqliMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "xssMatchStatementInput", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement? XssMatchStatementInput
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatementXssMatchStatement?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.wafv2.Wafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatement\"}", isOptional: true)]
        public virtual aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatement? InternalValue
        {
            get => GetInstanceProperty<aws.Wafv2.IWafv2WebAclRuleStatementManagedRuleGroupStatementScopeDownStatement?>();
            set => SetInstanceProperty(value);
        }
    }
}
