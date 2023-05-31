using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item_Bucket_Interaction : SimpleInteraction
{
    protected Item_Bucket _bucket;

    private void Awake()
    {
        _bucket = GetComponent<Item_Bucket>();
        _bucket.Type = WorldResource.EType.Water;
    }

    public override bool CanPerform()
    {
        return base.CanPerform() && !_bucket.IsOn;
    }
}
