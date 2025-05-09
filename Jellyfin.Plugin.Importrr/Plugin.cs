using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Plugins;
using MediaBrowser.Model.Serialization;

namespace Jellyfin.Plugin.Importrr;

public class Plugin : BasePlugin<PluginConfiguration>, IHasWebPages
{
    public override string Name => "Importrr";
    public override Guid Id => Guid.Parse("fec2137c-7400-473b-ab7d-a1279731e39a");

    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer) : base(applicationPaths, xmlSerializer)
    {
    }

    public IEnumerable<PluginPageInfo> GetPages()
    {
        return [
            new()
            {
                Name = Name,
                EmbeddedResourcePath = "Jellyfin.Plugin.Importrr.config.html"
            }
        ];
    }

}