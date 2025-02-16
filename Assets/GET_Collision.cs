using UnityEngine;
public class GET_Collision : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnTriggerEnter(Collider other)
    {
        // If the object that collided with this object has the tag "Player"
        if (other.CompareTag("TriggerObject"))
        {
            // Destroy the object that collided with this object
            Destroy(other.gameObject);
            // Show trigger feedback in Console Window
            print("Trigger object destroyed");
        }
    }
    void OnTriggerStay(Collider other)
    {
        // If the object that collided with this object has the tag "Player"
        if (other.CompareTag("TriggerObject"))
        {
            // Destroy the object that collided with this object
            // Destroy(other.gameObject);
            // Show trigger feedback in Console Window
            print("Trigger Stay");
        }
    }
    void OnTriggerExit(Collider other)
    {
        // If the object that collided with this object has the tag "Player"
        if (other.CompareTag("TriggerObject"))
        {
            // Destroy the object that collided with this object
            // Destroy(other.gameObject);
            // Show trigger feedback in Console Window
            print("Trigger Exit");
        }
    }
}