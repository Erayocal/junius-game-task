
using UnityEngine;

public class Player_fire : MonoBehaviour
{

    public GameObject Füze;
    public GameObject Fz;
    public Transform firePoint;
    [SerializeField] private float FüzeSp = 10f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fire();
        }

        //oyun ekranýndan çýktýktan sonra yok etmesi için
        if (transform.position.y > 15f)
        {
            Destroy(gameObject);
        }

    }

    private void fire()
    {
        //Füze yaratma ve hareketi
        GameObject Fz = Instantiate(Füze, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = Fz.GetComponent<Rigidbody2D>();

        rb.velocity = Vector2.up * FüzeSp;
    }
}
