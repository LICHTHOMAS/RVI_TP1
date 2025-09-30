using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    int compteur = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started Logs.cs Script");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(++compteur);
    }
}
