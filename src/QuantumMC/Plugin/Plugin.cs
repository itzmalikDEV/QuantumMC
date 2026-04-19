using QuantumMC.Plugin.Events;

namespace QuantumMC.Plugin;

public interface IPlugin {
    void OnEnable();
    void OnDisable();
    
    void OnPlayerJoined(PlayerJoinedEvent ev);
    void OnPlayerLeaved(PlayerLeavedEvent ev);
    void OnPlayerMove(PlayerMoveEvent ev);
    void OnPlayerAttackedEntity(PlayerAttackedEntityEvent ev);
    void OnPlayerAttackedPlayer(PlayerAttackedPlayerEvent ev);
    void OnPlayerSentMessage(PlayerSentMessageEvent ev);
    void OnPlayerSkinChanged(PlayerSkinChangedEvent ev);
    void OnPacketReceived(PacketEvent ev);
    void OnPacketSent(PacketEvent ev);
}

public interface HotReload {
    void OnReload();
}

public abstract class Plugin : IPlugin
{

    public virtual void OnEnable() { }
    public virtual void OnDisable() { }
    public virtual void OnReload() { }
    public virtual void OnPlayerJoined(PlayerJoinedEvent ev) { }
    public virtual void OnPlayerLeaved(PlayerLeavedEvent ev) { }
    public virtual void OnPlayerMove(PlayerMoveEvent ev) { }
    public virtual void OnPlayerAttackedEntity(PlayerAttackedEntityEvent ev) { }
    public virtual void OnPlayerAttackedPlayer(PlayerAttackedPlayerEvent ev) { }
    public virtual void OnPlayerSentMessage(PlayerSentMessageEvent ev) { }
    public virtual void OnPlayerSkinChanged(PlayerSkinChangedEvent ev) { }
    public virtual void OnPacketReceived(PacketEvent ev) { }
    public virtual void OnPacketSent(PacketEvent ev) { }
}

[AttributeUsage(AttributeTargets.Class)]
public class PluginInfo : Attribute
{
    public string Name { get; }
    public string Version { get; }
    public string[] Dependencies { get; }
    public string[] Authors { get; }
    public string Api { get; }

    public PluginInfo(string name, string version, params string[] dependencies string[] authors string api)
    {
        Name = name;
        Version = version;
        Dependencies = dependencies;
        Authors = authors;
        Api = api;
    }
}