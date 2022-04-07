using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AppearImage : MonoBehaviour
{

    [SerializeField]private Image customImage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            Time.timeScale = 1;
            customImage.enabled = false;
            Camera.main.GetComponent<AudioSource>().UnPause();
        }
 
 
    } 
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
               
            customImage.enabled = true;
            Time.timeScale = 0f;   
            Camera.main.GetComponent<AudioSource>().Pause();
    
        }
    }
}

