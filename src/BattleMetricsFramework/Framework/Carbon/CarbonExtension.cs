#if CARBON

using API.Assembly;
using JetBrains.Annotations;

namespace Oxide.Ext.BattleMetricsFramework;

[UsedImplicitly]
public class CarbonExtension : ICarbonExtension
{
    void ICarbonAddon.Awake(EventArgs args) { }

    void ICarbonAddon.OnLoaded(EventArgs args)
    {
        BattleMetricsUtility.Clear();
    }

    void ICarbonAddon.OnUnloaded(EventArgs args)
    {
        BattleMetricsUtility.Clear();
    }
}

#endif