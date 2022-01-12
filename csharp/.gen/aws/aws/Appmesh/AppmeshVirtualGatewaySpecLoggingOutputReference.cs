using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualGatewaySpecLoggingOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecLoggingOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualGatewaySpecLoggingOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualGatewaySpecLoggingOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecLoggingOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecLoggingOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putAccessLog", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLog\"}}]")]
        public virtual void PutAccessLog(aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetAccessLog")]
        public virtual void ResetAccessLog()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "accessLog", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference AccessLog
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "accessLogInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLog\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog? AccessLogInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLogging\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecLogging? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecLogging?>();
            set => SetInstanceProperty(value);
        }
    }
}
