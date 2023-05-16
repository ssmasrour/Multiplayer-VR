using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Avatar = Alteruna.Avatar;

public class PlayerInitializer : MonoBehaviour
{
    // hidden layer from camera
    [SerializeField] LayerMask _HiddenLayer;

    Avatar m_avatar;
    Camera m_camera;
    AvatarRandomizer m_avatarBody;

    void Start()
    {
        m_avatar = GetComponent<Avatar>();
        m_camera = GetComponentInChildren<Camera>();
        m_avatarBody = GetComponent<AvatarRandomizer>();

        CameraStateOverNetwork();
        AvatarBodyStateOverNetwork();
    }

    private void CameraStateOverNetwork()
    {
        m_camera.gameObject.SetActive(m_avatar.IsMe);
    }

    private void AvatarBodyStateOverNetwork()
    {
        if (m_avatar.IsMe)
        {
            m_avatarBody.SetLayer(_HiddenLayer);
        }
    }
}
