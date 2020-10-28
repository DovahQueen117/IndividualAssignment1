using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: Bonus - make this class a Singleton!

[System.Serializable]
public class BulletPoolManager : MonoBehaviour
{
    public GameObject bullet;
    public int MaxBullets;

    //TODO: create a structure to contain a collection of bullets
    private List<GameObject> bullets = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        // TODO: add a series of bullets to the Bullet Pool
        bullets = new List<GameObject>();
        for (int i = 0; i < MaxBullets; i++)
        {
            GameObject temp = Instantiate(bullet);
            temp.SetActive(false);
            bullets.Add(temp);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //TODO: modify this function to return a bullet from the Pool
    public GameObject GetBullet()
    {
        for (int i = 0; i < MaxBullets; i++)
        {
            if (!bullets[i].activeInHierarchy)
            {
                return bullets[i];
            }
        } 
        return null;
    }


    //TODO: modify this function to reset/return a bullet back to the Pool 
    public void ResetBullet(GameObject bullet)
    {
        bullet.SetActive(false);
    }
}
