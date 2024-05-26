using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovie : MonoBehaviour
{
    Rigidbody2D _rigidbody2D;
    BoxCollider2D _boxcollider2D;
    SpriteRenderer _spriterenderer;
    public float Speed = 1;
    int _xdirection = 1;
    int _ydirection = 1;
    void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _boxcollider2D = GetComponent <BoxCollider2D> ();
        _spriterenderer = GetComponent<SpriteRenderer>();
    }
    void FixedUpdate()
    {
        _rigidbody2D.velocity = new Vector2(Speed*_xdirection, Speed*_ydirection);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Horizontal")
        {
            Rotation();
            _xdirection = _xdirection *-1;
        }
        if (collision.gameObject.tag == "Vertical")
        {
            Rotation();
            _ydirection = _ydirection *-1;
        }
    }
    void Rotation()
    {
        if (_spriterenderer.flipX == false)
        {
            _spriterenderer.flipX = true;
            _spriterenderer.flipY = true;
        }
        else
        {
            _spriterenderer.flipX = false;
            _spriterenderer.flipY = false;
        }

    }
}
