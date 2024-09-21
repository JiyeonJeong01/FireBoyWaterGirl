using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public enum Gender { Boy, Girl }; // ����
    public enum PlayState { Idle, Play, Clear, Dead }; // �÷��� ���� : ���, �÷���, Ŭ����, ����


    public Gender gender;
    public PlayState playState;
    public float speedX = 8f, speedY = 10f;
    protected float inputX, inputY;
    protected bool isJumpReady = false, isGround = true;

    private Rigidbody2D rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playState = PlayState.Idle;
        rb.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    public virtual void Update()
    {
        // �ڽ� Ŭ�������� ����
    }

    public void FixedUpdate()
    {
        Move();
    }


    public void Move()
    {

        rb.velocity = new Vector2(inputX, rb.velocity.y);

        if (isJumpReady && isGround)
        {
            isGround = false;
            isJumpReady = false;
            rb.AddForce(Vector2.up * speedY, ForceMode2D.Impulse);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
    }

    public void EatItem()
    {
        // ������ ����
    }

    public void PlayerDead()
    {
        // �� ���� ��� ����
    }

}