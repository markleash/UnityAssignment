using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class PickupManager : MonoBehaviour
{
    private static PickupManager instance;
    //[SerializeField] GameObject pickupPrefab;
    [SerializeField] GameObject[] pickups;
    [SerializeField] private float pickupSpawnTime = 5f;
    //[SerializeField] private float pickupSpawnTimeResetter = 5f;
    private float timeElapsed;
    private float timeResetter = 5f;

    /*private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    */

    private void Update()
    {
        pickupSpawnTime -= Time.deltaTime;

            if (pickupSpawnTime <= 0)
            {
                Spawner();
                pickupSpawnTime = timeResetter;
            }
    }
    public static PickupManager GetInstance()
    {
        return instance;
    }

    private void Spawner()
    {
            //yield return new WaitForSeconds(5);
            int randomIndex = Random.Range(0, pickups.Length);
            GameObject newPickup = Instantiate(pickups[randomIndex]);
            newPickup.transform.position = new Vector3(Random.Range(7f,-25f), 20f, Random.Range(-9f, 26f));
    }
}

