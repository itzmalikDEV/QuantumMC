using System.Net;
using QuantumMC.Network;
using RaknetCS.Network;

namespace QuantumMC.Plugin.Events;

public class PacketEvent(IPEndPoint ep, Packet packet) : Event {

    private IPEndPoint EndPoint { get; } = ep;
    private Packet Packet { get; } = packet;

    public Player GetPlayer()
    {
        return Server.GetPlayer(RakSessionManager.getSession(ep).EntityID);
    }

    public IPEndPoint GetEndPoint() {
        return EndPoint;
    }

    public Packet GetPacket() {
        return Packet;
    }
}