using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateOnClick : MonoBehaviour
{
    public GameObject aCopier;
    public float yeetStrength = 1e-30f;
    private Rigidbody m_rigidbody;

    private void OnFire() {
        Debug.Log("Fired !");
        GameObject projectile = Instantiate(aCopier);
        m_rigidbody = projectile.GetComponent<Rigidbody>();

        Vector3 force = Camera.main.transform.forward * yeetStrength;

        projectile.transform.position = this.transform.position + this.transform.forward*2;
        m_rigidbody.AddForce(force, ForceMode.Force);
    }
}
