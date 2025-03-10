<<<<<<< Updated upstream
using System;
=======
>>>>>>> Stashed changes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
<<<<<<< Updated upstream
    private Transform _transform;
    private Rigidbody2D _rigidbody2D;
    
    public float velocidade = 10f;
    public float forcaPulo = 10f;

    private bool noChao = false;
    
    void Start()
    {
        _transform = gameObject.transform;
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    
    void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("chao")) //if (other.tag == "chao")
=======
  public float velocidade = 10f;
  public float focaPulo = 10f;

    public bool noChao = false;

    public bool andando = false;

  private Rigidbody2D _rigidbody2D;
  private SpriteRenderer  _spriteRenderer;
  private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _animator = gameObject.GetComponent<Animator>();
    }


   void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
>>>>>>> Stashed changes
        {
            noChao = true;
        }
    }

<<<<<<< Updated upstream
    
    void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("chao")) //if (other.tag == "chao")
=======
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chao")
>>>>>>> Stashed changes
        {
            noChao = false;
        }
    }
<<<<<<< Updated upstream
    
    void Update()
    {
        
        Debug.Log("No Chao: " + noChao);
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            _transform.position -= new Vector3(velocidade*Time.deltaTime,0,0);
           Debug.Log("LeftArrow");
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
           _transform.position += new Vector3(velocidade*Time.deltaTime,0,0);
           Debug.Log("RightArrow");
        }

        if (Input.GetKeyDown(KeyCode.Space) && noChao == true)
        {
           // forcaPulo
           _rigidbody2D.AddForce(new Vector2(0,forcaPulo),ForceMode2D.Impulse);
        }
=======

    // Update is called once per frame
    void Update()
    {
        andando = false;
        
      if(Input.GetKey(KeyCode.LeftArrow))
      {
        gameObject.transform.position += new Vector3(-velocidade*Time.deltaTime,0,0);
        //rigidbody2D.AddForce(new Vector2(-velocidade,0));
        _spriteRenderer.flipX = true;
        Debug.Log("LeftArrow");

        if (noChao == true)
        {
            andando = true;
        }
      }
        

      if(Input.GetKey(KeyCode.RightArrow))
      {
        gameObject.transform.position += new Vector3(velocidade*Time.deltaTime,0,0);
        //rigidbody2D.AddForce(new Vector2(velocidade,0));
         _spriteRenderer.flipX = false;
         Debug.Log("RightArrow");
         
         if (noChao == true)
         {
             andando = true;
         }
      }

        if (Input.GetKeyDown(KeyCode.Space) && noChao == true)
        {
            _rigidbody2D.AddForce(new Vector2(0, 1) * focaPulo,ForceMode2D.Impulse);

            Debug.Log("Jump");
        }

        _animator.SetBool("Andando",andando);
        
     
>>>>>>> Stashed changes
    }
}