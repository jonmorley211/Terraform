using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Athena
{
    [JsiiClass(nativeType: typeof(aws.Athena.AthenaWorkgroupConfigurationEngineVersionOutputReference), fullyQualifiedName: "aws.athena.AthenaWorkgroupConfigurationEngineVersionOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AthenaWorkgroupConfigurationEngineVersionOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AthenaWorkgroupConfigurationEngineVersionOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationEngineVersionOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AthenaWorkgroupConfigurationEngineVersionOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetSelectedEngineVersion")]
        public virtual void ResetSelectedEngineVersion()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "selectedEngineVersionInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? SelectedEngineVersionInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "selectedEngineVersion", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string SelectedEngineVersion
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.athena.AthenaWorkgroupConfigurationEngineVersion\"}", isOptional: true)]
        public virtual aws.Athena.IAthenaWorkgroupConfigurationEngineVersion? InternalValue
        {
            get => GetInstanceProperty<aws.Athena.IAthenaWorkgroupConfigurationEngineVersion?>();
            set => SetInstanceProperty(value);
        }
    }
}
