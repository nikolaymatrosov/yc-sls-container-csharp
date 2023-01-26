using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace yandex.AlbVirtualHost
{
    #pragma warning disable CS8618

    [JsiiByValue(fqn: "yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbac")]
    public class AlbVirtualHostRouteRouteOptionsRbac : yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbac
    {
        private object _principals;

        /// <summary>principals block.</summary>
        /// <remarks>
        /// Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#principals AlbVirtualHost#principals}
        /// </remarks>
        [JsiiProperty(name: "principals", typeJson: "{\"union\":{\"types\":[{\"fqn\":\"cdktf.IResolvable\"},{\"collection\":{\"elementtype\":{\"fqn\":\"yandex.albVirtualHost.AlbVirtualHostRouteRouteOptionsRbacPrincipals\"},\"kind\":\"array\"}}]}}")]
        public object Principals
        {
            get => _principals;
            set
            {
                if (Amazon.JSII.Runtime.Configuration.RuntimeTypeChecking)
                {
                    switch (value)
                    {
                        case HashiCorp.Cdktf.IResolvable cast_cd4240:
                            break;
                        case yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipals[] cast_cd4240:
                            break;
                        case Amazon.JSII.Runtime.Deputy.AnonymousObject cast_cd4240:
                            // Not enough information to type-check...
                            break;
                        case null:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipals).FullName}[]; received null", nameof(value));
                        default:
                            throw new System.ArgumentException($"Expected {nameof(value)} to be one of: {typeof(HashiCorp.Cdktf.IResolvable).FullName}, {typeof(yandex.AlbVirtualHost.IAlbVirtualHostRouteRouteOptionsRbacPrincipals).FullName}[]; received {value.GetType().FullName}", nameof(value));
                    }
                }
                _principals = value;
            }
        }

        /// <summary>Docs at Terraform Registry: {@link https://www.terraform.io/docs/providers/yandex/r/alb_virtual_host#action AlbVirtualHost#action}.</summary>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }
    }
}
