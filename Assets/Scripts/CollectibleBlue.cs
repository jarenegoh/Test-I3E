using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleBlue : MonoBehaviour
{
    int collectibleBlue = 15;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Player>().IncreaseScore(collectibleBlue);
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
