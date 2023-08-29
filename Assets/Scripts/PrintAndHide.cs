using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    int i = 3;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ':'+i) ;
        if (gameObject.tag =="Red")
        {
            if (i == 100)
            {
                gameObject.SetActive(false);
            }
        } 
        if (gameObject.tag == "Blue")
        {
            if (i == Random.Range(150, 251))
            {
                rend.enabled = false;
            }
        }
    }
}
