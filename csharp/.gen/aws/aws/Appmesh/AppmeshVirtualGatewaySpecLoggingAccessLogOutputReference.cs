using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshVirtualGatewaySpecLoggingAccessLogOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putFile", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogFile\"}}]")]
        public virtual void PutFile(aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLogFile @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLogFile)}, new object[]{@value});
        }

        [JsiiMethod(name: "resetFile")]
        public virtual void ResetFile()
        {
            InvokeInstanceVoidMethod(new System.Type[]{}, new object[]{});
        }

        [JsiiProperty(name: "file", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogFileOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogFileOutputReference File
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogFileOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "fileInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLogFile\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLogFile? FileInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLogFile?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshVirtualGatewaySpecLoggingAccessLog\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshVirtualGatewaySpecLoggingAccessLog?>();
            set => SetInstanceProperty(value);
        }
    }
}
