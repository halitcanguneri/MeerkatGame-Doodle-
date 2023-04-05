using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Karakter"))
        {
            if(collision.relativeVelocity.y<=0f)// yukarý doðru zýplamasý bittiðinde yeni zýplama devreye girecek
            {
                collision.gameObject.GetComponent<Karakter>().KarakterZiplat();
            }
            
        }
    }
}
