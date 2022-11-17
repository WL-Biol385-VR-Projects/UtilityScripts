using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleculeSpawner : MonoBehaviour
{

  public Transform moleculePrefab;
  public int moleculeCount = 1;
  public float maxDistance = 1;
  public float maxVelocity = 0;

  private List<Transform> molecules;

  private void spawnMolecules()
  {

    for (var i = 0; i < moleculeCount; i++)
    {
        float x = Random.Range(-1 * maxDistance, maxDistance),
        float y = Random.Range(-1 * maxDistance, maxDistance),
        float z = Random.Range(-1 * maxDistance, maxDistance);

        Transform obj = (Transform)Instantiate(moleculePrefab, new Vector3(x, y, z), Quaternion.identity);

        float min = -1 * maxVelocity;
        float max = maxVelocity;

        Vector3 v = new Vector3(Random.Range(min, max), Random.Range(min, max), Random.Range(min, max));
        obj.GetComponent<Rigidbody>().AddForce(v, ForceMode.VelocityChange);

    }

  }


}
