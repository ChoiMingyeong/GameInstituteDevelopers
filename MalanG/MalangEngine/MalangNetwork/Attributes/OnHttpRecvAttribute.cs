// Copyright MUMO STUDIO, Inc. All Rights Reserved.

namespace MalangNetwork.Attributes;

public enum eHttpMethod
{
    Get,
    Post,
}

[AttributeUsage(AttributeTargets.Method)]
public class OnHttpRecvAttribute
{
    public eHttpMethod MethodType { get; }
    public string Url { get; }

    public OnHttpRecvAttribute(eHttpMethod methodType, string url)
    {
        MethodType = methodType;
        Url = url;
    }
}