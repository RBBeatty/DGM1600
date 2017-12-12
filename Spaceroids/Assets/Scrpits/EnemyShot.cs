using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour { 
    public Vector3 bulletoffset = new Vector3(0, 0.5f, 0);
    public GameObject bulletPrefab;
    public float fireDelay = 0.5f;
    float cooldownTimer = 0;
    // Update is called once per frame
    void Update()
    {
        cooldownTimer -= Time.deltaTime;

        if (cooldownTimer <= 0)
        {
            //Shoot!
            Debug.Log("Pew!)");
            cooldownTimer = fireDelay;

            Vector3 offset = transform.rotation * bulletoffset;
            Instantiate(bulletPrefab, transform.position, transform.rotation);

        }
    }
 }