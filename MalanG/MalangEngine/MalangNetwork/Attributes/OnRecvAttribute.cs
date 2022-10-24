// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangNetwork.Attributes;

[AttributeUsage(AttributeTargets.Method)]
public class OnRecvAttribute : Attribute
{
    public ushort ProtocolType { get; }
    public bool Authorized { get; }

    public OnRecvAttribute(ushort protocolType, bool authorized = true)
    {
        ProtocolType = protocolType;
        Authorized = authorized;
    }
}