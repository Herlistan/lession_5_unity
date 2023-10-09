using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{
    public class Spawner : MonoBehaviour
    {
        public GameObject[] prefabs;
        public void Spawn()
        {
            Debug.Log("Try spawn!");

            var prefab = GetRandomPrefabs();

            if(prefab == null)
            {
                Debug.LogError("Spawner - prefab = null");
                return;
            }
            Instantiate(prefab, transform.position, Quaternion.identity);
        }
        
        private GameObject GetRandomPrefabs()
        {
            if (prefabs.Length == 0)
            {
                Debug.LogError("Spawner - prefabs is empty");
                return null;
            }

            int index = Random.Range(0, prefabs.Length); // генерация индекса объекта в массиве
            return prefabs[index];
        }
    }
}


