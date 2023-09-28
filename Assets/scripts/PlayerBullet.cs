using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed;
    public Rigidbody playerprojectile;
    public float BulletSpawnTime;
    public float SpawnMax = 10;
    public float SpawnMin = 5; 
    // Start is called before the first frame update
    void Start()
    {
        BulletSpawnTime = Random.Range(SpawnMax, SpawnMin);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerBullets();
    }

    void PlayerBullets()
    {
        BulletSpawnTime -= Time.deltaTime;
        if (BulletSpawnTime <= 0)
        {
            Instantiate(playerprojectile, transform.position,transform.rotation);
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            BulletSpawnTime = Random.Range(SpawnMin, SpawnMax);
        }

    }
}
