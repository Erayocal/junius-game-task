
using UnityEngine;

public class Enemy_movment : MonoBehaviour
{
    public Transform Player;
    [SerializeField] private float sp;
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Hedef").transform;
    }
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, sp * Time.deltaTime);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //astroitlerin büyüklüðüne göre canlarý
        if (collision.gameObject.tag == "Füze")
        {
            Destroy(gameObject);
        }
    }
}
