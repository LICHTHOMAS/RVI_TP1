using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float angularSpeed = 3.0f;
    public bool rotation = false;
    // Start is called before the first frame update
    void Start()
    {
    }
    private void OnRotate() {
        Debug.Log("R pressed !");
        rotation = !rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotation) { this.gameObject.transform.Rotate(new Vector3(0, angularSpeed * Time.deltaTime, 0)); }
    }
}
