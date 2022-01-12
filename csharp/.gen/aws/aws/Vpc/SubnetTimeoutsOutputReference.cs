using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Vpc
{
    [JsiiClass(nativeType: typeof(aws.Vpc.SubnetTimeoutsOutputReference), fullyQualifiedName: "aws.vpc.SubnetTimeoutsOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class SubnetTimeoutsOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public SubnetTimeoutsOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubnetTimeoutsOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SubnetTimeoutsOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "resetCreate")]
        public virtual void ResetCreate()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiMethod(name: "resetDelete")]
        public virtual void ResetDelete()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiOptional]
        [JsiiProperty(name: "createInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? CreateInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "deleteInput", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public virtual string? DeleteInput
        {
            get => GetInstanceProperty<string?>();
        }

        [JsiiProperty(name: "create", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Create
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiProperty(name: "delete", typeJson: "{\"primitive\":\"string\"}")]
        public virtual string Delete
        {
            get => GetInstanceProperty<string>()!;
            set => SetInstanceProperty(value);
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.vpc.SubnetTimeouts\"}", isOptional: true)]
        public virtual aws.Vpc.ISubnetTimeouts? InternalValue
        {
            get => GetInstanceProperty<aws.Vpc.ISubnetTimeouts?>();
            set => SetInstanceProperty(value);
        }
    }
}
