using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotGun : Weapon
{
    public override void Shoot(Transform shootPosition)
    {
        int bulletCount = 10;
        float randomPositionX;
        float randomPositionY;

        for (float i = 0; i < bulletCount; i++)
        {
            randomPositionX = Random.Range(0.1f, 0.5f);
            randomPositionY = Random.Range(0.1f, 0.5f);

            Instantiate(Bullet, shootPosition.position + new Vector3(randomPositionX, randomPositionY, 0), Quaternion.identity);
        }
    }
}
