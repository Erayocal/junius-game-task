
using UnityEngine;

public class Ast_movment : MonoBehaviour
{
    public AsteroidType asteroidType;
    Rigidbody2D rb;
    [SerializeField] private float sp;
    [SerializeField] private float ast_health;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.x, sp * Time.deltaTime);

        if(ast_health==0)
        {
            ast_count.astcalss.ast_cnt();
            GameObject.FindObjectOfType<Ast_spawner>().ReturnAstToPool(this.gameObject, asteroidType);
        }
        
        // E�er f�ze oyun alan�ndan ��kt�ysa, havuza geri koy
        if (transform.position.y > 15f || transform.position.y < -15f ||
            transform.position.x > 10f || transform.position.x < -10f)
        {
            GameObject.FindObjectOfType<Ast_spawner>().ReturnAstToPool(this.gameObject, asteroidType);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //astroitlerin b�y�kl���ne g�re canlar�
        if(collision.gameObject.tag=="F�ze")
        {
            ast_health -= 10;
        }

        
        if (collision.gameObject.tag == "Shield_player")
        {
            GameObject.FindObjectOfType<Ast_spawner>().ReturnAstToPool(this.gameObject, asteroidType);
        }
    }
}
