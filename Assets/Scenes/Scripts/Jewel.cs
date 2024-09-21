using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : TriggerController //TriggerController 상속
{
    public GameObject Movement; //제대로 받는지 확인하려고 한거 무시해도 됌

    protected override void ItemGain()
    {
        base.ItemGain(); //가상 함수
        Destroy(gameObject);
    }
}