
using UnityEngine;

public class Enemy_movment : MonoBehaviour
{
    public Transform Player;
    [SerializeField] private float sp;
    void Start()
    {
        //Uzat gemisinin tam ortas�ndaki hedef.
        Player = GameObject.FindGameObjectWithTag("Hedef").transform;
    }
    void Update()
    {
        //Oyuncuyu takip eden f�ze.
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, sp * Time.deltaTime);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "F�ze")
        {
            Destroy(gameObject);
        }
    }
}
