using UnityEngine.Events;

public sealed class IntEvent : UnityEvent<int>//inr型のイベント作成
{
}

public sealed class BoolEvent : UnityEvent<bool>//bool型のイベント作成
{
}

public sealed class FloatEvent : UnityEvent<float>//float型のイベント作成
{
}
public sealed class StringEvent : UnityEvent<string>//string型のイベント作成
{
}
public sealed class Event : UnityEvent
{
}