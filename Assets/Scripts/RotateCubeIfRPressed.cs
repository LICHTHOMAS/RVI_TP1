using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEditor;

public class RotateCubeIfRPressed : MonoBehaviour,
IPointerEnterHandler, IPointerExitHandler,
IPointerDownHandler
{
    public bool rotate = false;
    public float angularSpeed = 10.0f;
    public float yeetStrength = 100000.0f;

    private Renderer m_renderer;
    private Rigidbody m_rigidbody;
    private Color m_originalColor;


    // Start is called before the first frame update
    void Start()
    {
        m_renderer = this.GetComponent<Renderer>();
        m_rigidbody = this.GetComponent<Rigidbody>();
        m_originalColor = m_renderer.material.color;
    }

    // Update is called once per frame
    void Update()
    {
        if (rotate) { this.transform.Rotate(new Vector3(0, angularSpeed * Time.deltaTime, 0)); }
    }

    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        Debug.Log("In\n");
        m_renderer.material.color = Color.yellow;
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        Debug.Log("Out\n");
        m_renderer.material.color = m_originalColor;
    }
    public void OnPointerDown(PointerEventData pointerEventData)
    {
        Debug.Log("Click !\n");
        m_rigidbody.AddForce(Camera.main.transform.forward * yeetStrength);
        rotate = !rotate;
    }
}
