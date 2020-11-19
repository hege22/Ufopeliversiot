
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public int damage = 1;
    public float speed;

    public GameObject effect; 

    private void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other) //collideri2dn aktivoituessa efekti aktivoituu ja pelaaja ottaa vahinkoa
    {
        if (other.CompareTag("Player"))
        {
            Instantiate(effect, transform.position, Quaternion.identity);

            // pelaaja ottaa vahinkoa
            other.GetComponent<Player>().health -= damage;
            Debug.Log(other.GetComponent<Player>().health);
            Destroy(gameObject);
        }

    }
}