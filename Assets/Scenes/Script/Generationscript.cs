using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generationscript : MonoBehaviour
{
    [System.Serializable]
    public struct SpawnableObject
    {
        
        public GameObject prefab;
        [Range(0f, 1f)]
        public float spawnChance;
    }
    public SpawnableObject[] objects;

    public float minRate = 1f;
    public float maxRate = 2f;

    private void OnEnable()
    {
        Invoke(nameof(Spawn), Random.Range(minRate, maxRate));
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void Spawn()
    {
        float Spawnchance = Random.value;

        foreach (var obj in objects)
        {
            if(Spawnchance > obj.spawnChance)
            {
                GameObject Threat = Instantiate(obj.prefab);
                Threat.transform.position += transform.position;
            }
        }
    }
}


