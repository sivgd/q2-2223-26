using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHeart : MonoBehaviour
{
    public GameObject heartPrefab;
    public Health playerHealth;
    List<HeartController> hearts = new List<HeartController>();

    private void OnEnable()
    {
        Health.OnPlayerDamaged += DrawHearts;
    }

    private void OnDisable()
    {
        Health.OnPlayerDamaged -= DrawHearts;
    }

    private void Start()
    {
        DrawHearts();
    }

    public void DrawHearts()
    {
        ClearHearts();

        //float maxHealthRemainder = playerHealth.maxHealth; 
        int heartsToMake = playerHealth.maxHealth; //(int)((playerHealth.maxHealth / 2) + maxHealthRemainder);

        for(int i = 0; i < heartsToMake; i++)
        {
            CreateEmptyHeart();
        }

        //THIS LOOP SHOULD UPDATE THEM ACCORDINGLY
        //looks at amount of hearts
        for(int i = 0; i < hearts.Count; i++)
        {
            //grabs the heart status (reference heartcontroller script where full heart = 1 and empty = 0)
            int heartStatus = (int)Mathf.Clamp(playerHealth.currentHealth, 0, 1);
            hearts[i].SetHeartImage((HeartStatus)heartStatus);

        }
    }

    public void CreateEmptyHeart()
    {
        GameObject newHeart = Instantiate(heartPrefab);
        newHeart.transform.SetParent(transform);

        HeartController heartComponent = newHeart.GetComponent<HeartController>();
        heartComponent.SetHeartImage(HeartStatus.Empty);
        hearts.Add(heartComponent);
    }

    public void ClearHearts()
    {
        foreach(Transform t in transform)
        {
            Destroy(t.gameObject);
        }
        hearts = new List<HeartController>();
    }
}
