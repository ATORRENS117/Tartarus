using UnityEngine;

public class GlobalAmmo : MonoBehaviour
{
    public static int handgunAmmoCount = 8;
    [SerializeField] GameObject ammoDisplay;
    void Update()
    {
        ammoDisplay.GetComponent<TMPro.TMP_Text>().text = "" + handgunAmmoCount;
    }
}
