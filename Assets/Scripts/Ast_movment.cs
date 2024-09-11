
using UnityEngine;

public class Ast_movment : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] private float sp;
    [SerializeField] private float ast_health;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        //kameranýn dýþýna çýktýðýnda yok etmek için
        float downEdge = Camera.main.ScreenToViewportPoint(Vector3.zero).y - 9f;  
        rb.velocity = new Vector2(rb.velocity.x, sp * Time.deltaTime);

        if(ast_health<=0)
        {
            //Her astroit yok edildiðinde Astroits classýnda bulunan sayacý arttýrarak yok patlatýlanlarýn sayýsýný oyuncu görebilecek.
            Astroits.instance.sayac++;
            Destroy(gameObject);
        }
        if (transform.position.y < downEdge)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //astroitlerin büyüklüðüne göre canlarý
        if(collision.gameObject.tag=="Füze")
        {
            ast_health -= 10;
        }

        //Kalkan ile temas ettiði zaman büyüklük farketmeksizin direkt yok ediyor.
        if (collision.gameObject.tag == "Shield_player")
        {
            Destroy(gameObject);
        }
    }
}
