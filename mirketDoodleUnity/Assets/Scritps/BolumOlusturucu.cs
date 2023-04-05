using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolumOlusturucu : MonoBehaviour
{
    public GameObject platformPrefab;
    [SerializeField] int platformSayisi = 20;
    // en sol -2,20f
    // en sað 2,20f
    void Start()
    {
        LevelUret();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LevelUret()
    {
        Vector2 platformVektoru = new Vector2();
        for(int i =0; i < platformSayisi; i++)
        {
            GameObject tempPlatform = Instantiate(platformPrefab);
            platformVektoru.x = Random.Range(2.2f,-2.2f);
            platformVektoru.y += Random.Range(1.6f, 1.61f);
            tempPlatform.transform.position = platformVektoru;
             

        }
    }
}
