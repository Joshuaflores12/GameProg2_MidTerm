using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyColorAndBulletColor : MonoBehaviour
{
    public Renderer PlayerColor, BulletColor, PlayerGunColor;
    public Color[] colors; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RendPlayerandBulletColor();
    }
    void RendPlayerandBulletColor() 
    {
    PlayerColor = GetComponent<Renderer>();
    BulletColor = GetComponent<Renderer>(); 
    PlayerGunColor = GetComponent<Renderer>();
    }

    [System.Obsolete]
    private void OnMouseDown()
    {
        PlayerColor.material.color = colors[Random.RandomRange(0, colors.Length)];
        BulletColor.material.color = colors[Random.RandomRange(0, colors.Length)];
        PlayerGunColor.material.color = colors[Random.RandomRange(0, colors.Length)];
    }
}
