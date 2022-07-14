using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToBeContinue : MonoBehaviour
{
    
    public GameObject toBeContinuePanel;


    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player"){

            
            StartCoroutine(ShowPanel());

        }
    }

    private IEnumerator ShowPanel(){

        yield return new WaitForSeconds(2);

        toBeContinuePanel.SetActive(true);

    }


}
