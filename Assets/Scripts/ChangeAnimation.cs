using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        
    private void OnTriggerEnter(Collider other)
        {
             GetComponent<Animator>().SetTrigger("ChangeAnimation");
        }
         private void OnTriggerExit(Collider other)
        {
             GetComponent<Animator>().SetTrigger("ChangeAnimation");
        }
}
