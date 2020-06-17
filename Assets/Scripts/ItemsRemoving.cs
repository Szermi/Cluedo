using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsRemoving : MonoBehaviour
{
    public HeroController hero;
    public GameObject hammerPrefab;
    public GameObject bottlePrefab;
    public GameObject hachePrefab;
    public GameObject knifePrefab;
    public GameObject shovelPrefab;
    public GameObject ropePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1") && hero.itemsList.Contains("Bottle"))
        {
            Instantiate(bottlePrefab, new Vector3(hero.transform.position.x + 5, 1.5f, hero.transform.position.z), Quaternion.identity);
            hero.itemsList.Remove("Bottle");
        }

        if (Input.GetKeyDown("2") && hero.itemsList.Contains("Hammer"))
        {
            Instantiate(hammerPrefab, new Vector3(hero.transform.position.x + 5, 1.5f, hero.transform.position.z), Quaternion.identity);
            hero.itemsList.Remove("Hammer");
        }

        if (Input.GetKeyDown("3") && hero.itemsList.Contains("Hache"))
        {
            Instantiate(hachePrefab, new Vector3(hero.transform.position.x + 5, 1.5f, hero.transform.position.z), Quaternion.identity);
            hero.itemsList.Remove("Hache");
        }

        if (Input.GetKeyDown("4") && hero.itemsList.Contains("Knife"))
        {
            Instantiate(knifePrefab, new Vector3(hero.transform.position.x + 5, 1.5f, hero.transform.position.z), Quaternion.identity);
            hero.itemsList.Remove("Knife");
        }

        if (Input.GetKeyDown("5") && hero.itemsList.Contains("Shovel"))
        {
            Instantiate(shovelPrefab, new Vector3(hero.transform.position.x + 5, 1.5f, hero.transform.position.z), Quaternion.identity);
            hero.itemsList.Remove("Shovel");
        }

        if (Input.GetKeyDown("6") && hero.itemsList.Contains("Rope"))
        {
            Instantiate(ropePrefab, new Vector3(hero.transform.position.x + 5, 1.5f, hero.transform.position.z), Quaternion.identity);
            hero.itemsList.Remove("Rope");
        }
    }
}
