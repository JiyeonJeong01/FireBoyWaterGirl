using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWater : Player
{
    public override void Update()
    {
        if (playState == PlayState.Dead) { return; } // �׾��ٸ� �������� ���ϵ��� ����

        inputX = Input.GetKey(KeyCode.A) ? -speedX : Input.GetKey(KeyCode.D) ? speedX : 0;

        if (isGround && Input.GetKeyDown(KeyCode.W))
        {
            isJumpReady = true;
        }
    }
}
