using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D whatIHit)
    {
        if (whatIHit.tag == "Player")
        {
            //I hit the Player!
            Destroy(this.gameObject);
        }
        else if (whatIHit.tag == "Weapon")
        {
            //I am shot!
            GameObject.Find("GameManager").GetComponent<GameManager>().EarnScore(3);
     
            Destroy(whatIHit.gameObject);
            Destroy(this.gameObject);
        }
    }
}