#if OXIDE

using JetBrains.Annotations;
using Oxide.Core;
using Oxide.Core.Extensions;

namespace Oxide.Ext.BattleMetricsFramework;

[UsedImplicitly]
public class BattleMetricsFramework : Extension
{
    public override string Name => "BattleMetricsFramework";
    public override string Author => "Ilovepatatos";
    public override VersionNumber Version => new(1, 0, 0);

    public override bool SupportsReloading => true;

    public BattleMetricsFramework(ExtensionManager manager) : base(manager) { }

    public override void Load()
    {
        base.Load();
        BattleMetricsUtility.Clear();
    }

    public override void Unload()
    {
        BattleMetricsUtility.Clear();
        base.Unload();
    }

    public override IEnumerable<string> GetPreprocessorDirectives()
    {
        yield return "BATTLE_METRICS_FRAMEWORK";
    }
}

#endif