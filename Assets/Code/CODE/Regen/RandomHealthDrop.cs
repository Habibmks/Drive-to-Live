using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHealthDrop : MonoBehaviour
{
    public GameObject HealthDrop;
    public float respawnTime = 30.0f;
    private Vector2 screenBound;
    // Start is called before the first frame update
    void Start()
    {
        screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height,
            Camera.main.transform.position.z));
        StartCoroutine(healthFall());
    }
    private void SpawnHealth()
    {
        GameObject h = Instantiate(HealthDrop) as GameObject;
        h.transform.position = new Vector2(Random.Range(-screenBound.x+1, screenBound.x-1), screenBound.y -1);
    }
    IEnumerator healthFall()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            SpawnHealth();
        }
    }
}
