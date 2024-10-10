using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollSpawnScript : MonoBehaviour
{
    [SerializeField]
    private GameObject ragdollGameObject;
    [SerializeField]
    private Transform originalRootBone;

    void Update()
    {
        if (GameManager.GameState.GameOver == GameManager.gameManager.GetGameState())
        {
            RagdollSetupScript ragdollSetupScript = Instantiate(ragdollGameObject, transform.position, transform.rotation).GetComponent<RagdollSetupScript>();
            ragdollSetupScript.Setup(originalRootBone);
            Destroy(this.gameObject);
        }
    }
}
