
using UnityEngine;

public class Enemy_movment : MonoBehaviour
{
    public Transform Player;
    [SerializeField] private float sp;
    void Start()
    {
        //Uzat gemisinin tam ortasýndaki hedef.
        Player = GameObject.FindGameObjectWithTag("Hedef").transform;
    }
    void Update()
    {
        //Oyuncuyu takip eden füze.
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, sp * Time.deltaTime);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "Füze")
        {
            Destroy(gameObject);
        }
    }
}
