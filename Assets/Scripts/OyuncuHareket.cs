using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OyuncuHareket : MonoBehaviour
{
    Rigidbody2D rb2D;
    Animator animator;
    Vector2 velocity;
    int ziplamalimiti = 3;
    int ziplamasayisi;
    Joystick joystick;
    Joystickbutton joystickbutton;
    bool zipliyor;

    void Start()
    {
        rb2D = GetComponent < Rigidbody2D >();
        animator = GetComponent<Animator>();
        joystick = FindObjectOfType<Joystick>();
        joystickbutton = FindObjectOfType<Joystickbutton>();
    }

    void Update()
    {
#if UNITY_EDITOR
        klavyeKontrol();
#else
        joystickkontrol();
#endif
    }

    void klavyeKontrol()
    {
        float hareketInput = Input.GetAxisRaw("Horizontal");
        Vector2 scale = transform.localScale;
        if (hareketInput > 0) //sağa yürüt
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * 3.0f, 10.0f * Time.deltaTime);
            animator.SetBool("Walk", true);
            scale.x = 0.4f;
        }else if (hareketInput < 0) //sola yürüt
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketInput * 3.0f, 10.0f * Time.deltaTime);
            animator.SetBool("Walk", true);
            scale.x = -0.4f;
        }
        else //durdur
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, 50.0f * Time.deltaTime);
            animator.SetBool("Walk", false);
        }
        gameObject.transform.Translate(velocity * Time.deltaTime);
        transform.localScale = scale;

        if (Input.GetKeyDown("space")) //basıldığında
        {
            ziplamabaslat();
        }
        if (Input.GetKeyUp("space")) //bırakıldığında
        {
            ziplamdurdur();
        }
    }

    void joystickkontrol()
    {
        float hareketınput = joystick.Horizontal;
        Vector2 scale = transform.localScale;
        if (hareketınput > 0) //sağa yürüt
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketınput * 3.0f, 10.0f * Time.deltaTime);
            animator.SetBool("Walk", true);
            scale.x = 0.4f;
        }
        else if (hareketınput < 0) //sola yürüt
        {
            velocity.x = Mathf.MoveTowards(velocity.x, hareketınput * 3.0f, 10.0f * Time.deltaTime);
            animator.SetBool("Walk", true);
            scale.x = -0.4f;
        }
        else //durdur
        {
            velocity.x = Mathf.MoveTowards(velocity.x, 0, 50.0f * Time.deltaTime);
            animator.SetBool("Walk", false);
        }
        gameObject.transform.Translate(velocity * Time.deltaTime);
        transform.localScale = scale;

        if (joystickbutton.tusaBasildi==true && zipliyor==false)
        {
            zipliyor = true;
            ziplamabaslat();
        }

        if (joystickbutton.tusaBasildi == false && zipliyor==true)
        {
            zipliyor = false;
            ziplamdurdur();
        }
    }

    void ziplamabaslat()
    {
        if (ziplamasayisi < ziplamalimiti)
        {
            FindObjectOfType<SesKontrol>().ZiplamaSes();
            rb2D.AddForce(new Vector2(0, 70.0f), ForceMode2D.Impulse);
            animator.SetBool("Jump", true);
            FindObjectOfType<SliderControl>().SliderDeger(ziplamalimiti, ziplamasayisi);
        }
        
    }

    void ziplamdurdur()
    {
        animator.SetBool("Jump", false);
        ziplamasayisi++;
        FindObjectOfType<SliderControl>().SliderDeger(ziplamalimiti, ziplamasayisi);
    }

    public void ziplamayisifirla()
    {
        ziplamasayisi = 0;
        FindObjectOfType<SliderControl>().SliderDeger(ziplamalimiti, ziplamasayisi);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Olum")
        {
            FindObjectOfType<OyunKontrol>().OyunuBitir();
        }
    }
    public void oyunbitti()
    {
        Destroy(gameObject);
    }
}