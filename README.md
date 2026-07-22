# BattleMetrics Framework
BattleMetrics framework for [Rust](https://store.steampowered.com/app/252490/Rust/) using the [Oxide/uMod](https://umod.org) or [Carbon](https://carbonmod.gg) extension platforms to expose useful API methods for plugins.

## Getting Started
Download the artifact for your extension platform from the latest release:

### Oxide/uMod
1. Download `Oxide.Ext.BattleMetricsFramework.dll`.
2. Put the DLL into the `RustDedicated_Data\Managed` folder.
3. Restart the server

### Carbon
1. Download `Carbon.Ext.BattleMetricsFramework.dll`.
2. Put the DLL into the `carbon\extensions` folder.
3. Restart the server.

## Usage
```csharp
using Oxide.Ext.BattleMetricsFramework;

// some code
BattleMetricsUtility.GetOrganizationServers(token, organizationID, jObject =>
{
    foreach (BattleMetricsServer bmServer in jObject.GetBattleMetricsServers())
        Debug.Log($"{bmServer.ID} - {bmServer.Name}");
});
```
