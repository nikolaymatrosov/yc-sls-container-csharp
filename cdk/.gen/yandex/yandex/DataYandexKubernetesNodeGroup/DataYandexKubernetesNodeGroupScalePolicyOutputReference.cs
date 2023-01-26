using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexKubernetesNodeGroup
{
    [JsiiClass(nativeType: typeof(yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyOutputReference), fullyQualifiedName: "yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyOutputReference", parametersJson: "[{\"docs\":{\"summary\":\"The parent resource.\"},\"name\":\"terraformResource\",\"type\":{\"fqn\":\"cdktf.IInterpolatingParent\"}},{\"docs\":{\"summary\":\"The attribute on the parent resource this class is referencing.\"},\"name\":\"terraformAttribute\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"the index of this item in the list.\"},\"name\":\"complexObjectIndex\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"whether the list is wrapping a set (will add tolist() to be able to access an item via an index).\"},\"name\":\"complexObjectIsFromSet\",\"type\":{\"primitive\":\"boolean\"}}]")]
    public class DataYandexKubernetesNodeGroupScalePolicyOutputReference : HashiCorp.Cdktf.ComplexObject
    {
        /// <param name="terraformResource">The parent resource.</param>
        /// <param name="terraformAttribute">The attribute on the parent resource this class is referencing.</param>
        /// <param name="complexObjectIndex">the index of this item in the list.</param>
        /// <param name="complexObjectIsFromSet">whether the list is wrapping a set (will add tolist() to be able to access an item via an index).</param>
        public DataYandexKubernetesNodeGroupScalePolicyOutputReference(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet): base(_MakeDeputyProps(terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(HashiCorp.Cdktf.IInterpolatingParent terraformResource, string terraformAttribute, double complexObjectIndex, bool complexObjectIsFromSet)
        {
            return new DeputyProps(new object?[]{terraformResource, terraformAttribute, complexObjectIndex, complexObjectIsFromSet});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexKubernetesNodeGroupScalePolicyOutputReference(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected DataYandexKubernetesNodeGroupScalePolicyOutputReference(DeputyProps props): base(props)
        {
        }

        [JsiiProperty(name: "autoScale", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyAutoScaleList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyAutoScaleList AutoScale
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyAutoScaleList>()!;
        }

        [JsiiProperty(name: "fixedScale", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyFixedScaleList\"}")]
        public virtual yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyFixedScaleList FixedScale
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicyFixedScaleList>()!;
        }

        [JsiiOptional]
        [JsiiProperty(name: "internalValue", typeJson: "{\"fqn\":\"yandex.dataYandexKubernetesNodeGroup.DataYandexKubernetesNodeGroupScalePolicy\"}", isOptional: true)]
        public virtual yandex.DataYandexKubernetesNodeGroup.IDataYandexKubernetesNodeGroupScalePolicy? InternalValue
        {
            get => GetInstanceProperty<yandex.DataYandexKubernetesNodeGroup.IDataYandexKubernetesNodeGroupScalePolicy?>();
            set => SetInstanceProperty(value);
        }
    }
}
