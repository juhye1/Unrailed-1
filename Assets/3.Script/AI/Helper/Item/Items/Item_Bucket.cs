using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Bucket : AI_Item
{
    public bool IsOn { get; protected set; } = false;
    public bool Full { get; protected set; } = false;

    public void PickUp()
    {
        IsOn = !IsOn;
        Debug.Log($"양동이는 지금 {(IsOn ? "들려있어용" : "바닥이에용")}");
    }

    public void BucketisFull()
    {
        Full = !Full;
        Debug.Log($"양동이는 지금 {(Full ? "다 찼어요" : "비어있어요")}");
    }
}
