using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    //Track
    public static int totalCoins = 0;

    private void Awake()
    {
        //Trigger
        GetComponent<Collider2D>().isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D c2d)
    {
        //Destroy
        if (c2d.CompareTag("Player"))
        {
            //Add
            totalCoins++;
            //Total
            Destroy(gameObject);
        }
    }
}
