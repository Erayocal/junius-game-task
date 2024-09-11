
using UnityEngine;

public class Player_fire : MonoBehaviour
{

    public GameObject Füze;
    public GameObject Fz;
    public Transform firePoint;
    [SerializeField] private float FüzeSp = 10f;

    //[SerializeField] private AudioSource füzesesi;

    void Update()
    {
        //Ateþ tuþunu mouse'a taþýyarak tek elle rahat oynanýlabilecek hale getirdim.
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            /*eðer elimde ses olsaydý bu þekilde eklerdim
              füzesesi.Play();
             */
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

        rb.velocity = firePoint.up * FüzeSp;
    }
}
