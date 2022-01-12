using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Ecr
{
    [JsiiClass(nativeType: typeof(aws.Ecr.EcrReplicationConfigurationReplicationConfigurationOutputReference), fullyQualifiedName: "aws.ecr.EcrReplicationConfigurationReplicationConfigurationOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class EcrReplicationConfigurationReplicationConfigurationOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public EcrReplicationConfigurationReplicationConfigurationOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrReplicationConfigurationReplicationConfigurationOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected EcrReplicationConfigurationReplicationConfigurationOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiOptional]
        [JsiiProperty(name: "ruleInput", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public virtual aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule[]? RuleInput
        {
            get => GetInstanceProperty<aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule[]?>();
        }

        [JsiiProperty(name: "rule", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfigurationRule\"},\"kind\":\"array\"}}")]
        public virtual aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule[] Rule
        {
            get => GetInstanceProperty<aws.Ecr.IEcrReplicationConfigurationReplicationConfigurationRule[]>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.ecr.EcrReplicationConfigurationReplicationConfiguration\"}", isOptional: true)]
        public virtual aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration? InternalValue
        {
            get => GetInstanceProperty<aws.Ecr.IEcrReplicationConfigurationReplicationConfiguration?>();
            set => SetInstanceProperty(value);
        }
    }
}
