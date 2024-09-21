using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : Player
{
    public override void Update()
    {
        if (playState == PlayState.Dead) { return; } // �׾��ٸ� �������� ���ϵ��� ����

        inputX = Input.GetKey(KeyCode.LeftArrow) ? -speedX : Input.GetKey(KeyCode.RightArrow) ? speedX : 0;

        if (isGround && Input.GetKeyDown(KeyCode.UpArrow))
        {
            isJumpReady = true;
        }
    }
}
