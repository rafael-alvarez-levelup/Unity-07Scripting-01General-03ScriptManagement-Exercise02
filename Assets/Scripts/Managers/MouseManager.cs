using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public static MouseManager Instance
    {
        get
        {
            if (instance == null)
            {
                Debug.LogError("The Mouse Manager is NULL!");
            }
            return instance;
        }
    }

    private static MouseManager instance;
    private Camera mainCamera;

    private void Awake()
    {
        instance = this;

        mainCamera = Camera.main;
    }

    public Vector3 GetMouseWorldPosition()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = -mainCamera.transform.position.z;

        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(mousePosition);
        mouseWorldPosition.z = 0;
        return mouseWorldPosition;
    }
}