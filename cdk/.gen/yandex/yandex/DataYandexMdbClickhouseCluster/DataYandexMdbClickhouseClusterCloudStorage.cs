using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.DataYandexMdbClickhouseCluster
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.dataYandexMdbClickhouseCluster.DataYandexMdbClickhouseClusterCloudStorage")]
    public class DataYandexMdbClickhouseClusterCloudStorage : yandex.DataYandexMdbClickhouseCluster.IDataYandexMdbClickhouseClusterCloudStorage
    {
        private object _enabled;

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/d/mdb_clickhouse_cluster#enabled DataYandexMdbClickhouseCluster#enabled}.</summary>
        [JsiiProperty(name: "enabled", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"boolean\"},{\"fqn\":\"cdktf.IResolvable\"}]}}")]
        public object Enabled
        {
            get => _enabled;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case bool cast_cd4240:
                            break;
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: bool, {typeof(HashiCorp.Cdktf.IResolvable).FullName}; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _enabled = value;
            }
        }
    }
}
