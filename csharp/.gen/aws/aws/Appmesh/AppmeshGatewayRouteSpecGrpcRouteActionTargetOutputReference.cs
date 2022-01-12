using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace aws.Appmesh
{
    [JsiiClass(nativeType: typeof(aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference), fullyQualifiedName: "aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.ITerraformResource\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"True if this is a block, false if it's a list.\"},\"name\":\"isSingleItem\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="isSingleItem">True if this is a block, false if it's a list.</param>
        public AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference(HashiCorp.Cdktf.ITerraformResource terraformResource, string terraformAttribute, bool isSingleItem): base(new DeputyProps(new object?[]{terraformResource, terraformAttribute, isSingleItem}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected AppmeshGatewayRouteSpecGrpcRouteActionTargetOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "putVirtualService", parametersJson: "[{\"name\":\"value\",\"type\":{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService\"}}]")]
        public virtual void PutVirtualService(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService @value)
        {
            InvokeInstanceVoidMethod(new System.Type[]{typeof(aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService)}, new object[]{@value});
        }

        [JsiiProperty(name: "virtualService", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualServiceOutputReference\"}")]
        public virtual aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualServiceOutputReference VirtualService
        {
            get => GetInstanceProperty<aws.Appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualServiceOutputReference>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "virtualServiceInput", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService? VirtualServiceInput
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTargetVirtualService?>();
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"aws.appmesh.AppmeshGatewayRouteSpecGrpcRouteActionTarget\"}", isOptional: true)]
        public virtual aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget? InternalValue
        {
            get => GetInstanceProperty<aws.Appmesh.IAppmeshGatewayRouteSpecGrpcRouteActionTarget?>();
            set => SetInstanceProperty(value);
        }
    }
}
