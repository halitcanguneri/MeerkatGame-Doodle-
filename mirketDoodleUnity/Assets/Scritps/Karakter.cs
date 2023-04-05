using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    [SerializeField] float hareketHizi;//saða solo gitme
    [SerializeField] float ziplamaKuvveti;
    [SerializeField] float lookDirection = 0.1f;
    Rigidbody2D rb;
    private Transform characterTransform;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        characterTransform = transform;
    }

    
    void Update()
    {
        float horizontalInput = 0.1f;
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            float touchX = touch.position.x;

            // Ekranda sola tarafta dokunulduysa.
            if (touchX < Screen.width / 2f)
            {
                horizontalInput = -0.1f;
                gameObject.transform.Translate(horizontalInput * hareketHizi * Time.deltaTime, 0, 0);
            }
            // Ekranda sað tarafta dokunulduysa.
            else if (touchX > Screen.width / 2f)
            {
                horizontalInput = 0.1f;
                gameObject.transform.Translate(horizontalInput * hareketHizi * Time.deltaTime, 0, 0);
            }
        }

        //float horizontalInput = Input.GetAxis("Horizontal");
        

        if (horizontalInput > 0)
        {
            lookDirection = 0.3f;
        }
        else if (horizontalInput < 0)
        {
            lookDirection = -0.3f;
        }
        characterTransform.localScale = new Vector3(lookDirection, 0.3f, 0.3f);
    }
    public void KarakterZiplat()
    {
        rb.AddForce(Vector2.up * ziplamaKuvveti);
    }
}
