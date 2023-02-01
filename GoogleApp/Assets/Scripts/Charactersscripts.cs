using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Charactersscripts : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D r2d;
    private Animator _animator;
    private Vector3 charpos;
    private SpriteRenderer _spriterenderer;
    [SerializeField] private GameObject _camera;
    private int sayi;

    void Start()
    {
        _spriterenderer = GetComponent<SpriteRenderer>();
        r2d = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
        charpos = transform.position;
        sayi = 1;


    }
    private void FixedUpdate()
    {
        sayi = 2;
        // r2d.velocity = new Vector2(speed, 0f);
    }
    // Update is called once per frame
    void Update()
    {
        
       
        charpos = new Vector3(charpos.x + (Input.GetAxis("Horizontal")*speed * Time.deltaTime), charpos.y);
        //transform.position = charpos; // hesapladýðým pozisyonu karakterime iþledim
        if (Input.GetAxis("Horizontal") == 0.0f)
        {
            _animator.SetFloat("speed",0.0f);
        }
        else
        {
            _animator.SetFloat("speed", speed);
            
        }
        if (Input.GetAxis("Horizontal" )> 0.01f)
        {
            _spriterenderer.flipX = false;

        }
        else if (Input.GetAxis("Horizontal") < -0.01)
        {
            _spriterenderer.flipX = true;
        }
     
        sayi = 3;
    }

     private void LateUpdate()
       {
        // _camera.transform.position = new Vector3(charpos.x, charpos.y, charpos.z - 1.0f);
        sayi = 4;
       }


}
