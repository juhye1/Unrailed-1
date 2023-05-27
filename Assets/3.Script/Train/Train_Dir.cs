using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Train_Dir : TrainMovement
{
    public Transform dirNiddle;

    private void Awake()
    {
        GetMesh();
        fireEffect.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        TrainMovePos();

        if (!isBurn)
        {
            Dir();
        }
    }

    void Dir()
    {
        if(ShopManager.Instance.endStation[0] != null)
        {
        Vector3 dirPos = ShopManager.Instance.endStation[0].transform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(dirPos);
        dirNiddle.transform.rotation = rotation;
        }
    }
}
