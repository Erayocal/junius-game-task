
using UnityEngine;

public class Player_fire : MonoBehaviour
{

    public GameObject F�ze;
    public GameObject Fz;
    public Transform firePoint;
    [SerializeField] private float F�zeSp = 10f;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            fire();
        }

        //oyun ekran�ndan ��kt�ktan sonra yok etmesi i�in
        if (transform.position.y > 15f)
        {
            Destroy(gameObject);
        }

    }

    private void fire()
    {
        //F�ze yaratma ve hareketi
        GameObject Fz = Instantiate(F�ze, firePoint.position, firePoint.rotation);

        Rigidbody2D rb = Fz.GetComponent<Rigidbody2D>();

        rb.velocity = Vector2.up * F�zeSp;
    }
}
