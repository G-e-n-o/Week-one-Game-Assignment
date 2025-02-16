using System;
using UnityEngine;
using Random = UnityEngine.Random;
public class GET_Raycast : MonoBehaviour
{
    public float range = 7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.back;
        Ray playerRay = new Ray(transform.position, transform.TransformDirection(direction * range));
        Debug.DrawRay(transform.position, transform.TransformDirection(direction * range), Color.red);
        if (Physics.Raycast(playerRay, out RaycastHit hit, range))
        {
            if (hit.collider.CompareTag("Static"))
            {
                // Destroy the object that collided with this object
                // Destroy(hit.collider.gameObject);
                // Show trigger feedback in Console Window
                print("My raycast hit a STATIC object");
            } 
            else if (hit.collider.CompareTag("Enemy"))
            {
                // Destroy the object that collided with this object
                // Destroy(hit.collider.gameObject);
                // Show trigger feedback in Console Window
                print("My raycast hit an ENEMY object");

        // new functionality: change the hit object's color to a random color
        if (hit.collider.CompareTag("Enemy"))
        {
            hit.collider.GetComponent<Renderer>().material.color = GetRandomColor();
        }
            }
        }
    }
    private Color GetRandomColor()
    {
        return new Color(UnityEngine.Random.value, UnityEngine.Random.value, UnityEngine.Random.value);
    }
}
