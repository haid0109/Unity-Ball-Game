using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //allows us to use the "Scenemanager" class

public class OnCollision : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) //is executed when an object collides with this object
    {
        Destroy(collision.gameObject); //destroys the object that collided this object
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); //reloads the current scene
    }
}
