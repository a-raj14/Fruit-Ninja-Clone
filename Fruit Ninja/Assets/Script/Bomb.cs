using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log(" <<<<bomb entered>>>>> ");
        if (other.CompareTag("Player"))
        {
            UnityEngine.Debug.Log(" touching bomb ");
            GetComponent<Collider>().enabled = false;
            FindObjectOfType<GameManager>().Explode();
            
        }
        else{
            UnityEngine.Debug.Log("not touching bomb ");
           
        }
    }
}
